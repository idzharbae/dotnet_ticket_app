using TicketApp.Internal.UseCase;
using TicketApp.Internal.Converter;
using TicketApp.Internal.Util;
using Payload = TicketApp.Internal.Payload;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Linq;


namespace TicketApp.Internal.Delivery.Grpc {
    #region snippet
    public class TicketService : TicketGrpc.TicketGrpcBase {
        private readonly ILogger<TicketService> _logger;
        private readonly ITicketUC _ticketUC;
        private readonly ICategoryUC _categoryUC;
        public TicketService(ILogger<TicketService> logger, ITicketUC ticketUC, ICategoryUC categoryUC) {
            _logger = logger;
            _ticketUC = ticketUC;
            _categoryUC = categoryUC;
        }

        public override Task<Category> GetCategory(Category req, ServerCallContext ctx) {
            Entity.Category category = _categoryUC.Get(new Entity.Category{
                Id = Guid.Parse(req.Id)
            });
            return Task.FromResult(CategoryConverter.CategoryEntityToProto(category));
        }
        public override Task<ListCategoryResp> ListCategory(ListCategoryReq req, ServerCallContext ctx) {
            Payload.ListCategoryResp categories = _categoryUC.List(new Payload.ListCategoryReq{
                page = req.Page,
                limit = req.Limit
            });
            ListCategoryResp result = new ListCategoryResp();
            result.Categories.Add(CategoryConverter.CategoryEntitiesToProtos(categories.categories));
            result.TotalResults = categories.totalCategories;
            return Task.FromResult(result);
        }
        public override Task<Category> CreateCategory(Category req, ServerCallContext ctx) {
            Entity.Category category = _categoryUC.Create(new Entity.Category{
                Name = req.Name
            });
            return Task.FromResult(CategoryConverter.CategoryEntityToProto(category));
        }
        public override Task<Category> UpdateCategory(Category req, ServerCallContext ctx) {
            Entity.Category category = _categoryUC.Update(new Entity.Category{
                Id = Guid.Parse(req.Id),
                Name = req.Name
            });
            return Task.FromResult(CategoryConverter.CategoryEntityToProto(category));
        }
        public override Task<Success> DeleteCategory(Category req, ServerCallContext ctx) {
            _categoryUC.Delete(new Entity.Category{
                Id = Guid.Parse(req.Id),
            });
            return Task.FromResult(new Success{
                Success_ = true
            });
        }
        public override Task<Ticket> GetTicket(Ticket req, ServerCallContext ctx) {
            Entity.Ticket result = _ticketUC.Get(TicketConverter.TicketProtoToEntity(req));
            return Task.FromResult(TicketConverter.TicketEntityToProto(result));
        }
        public override Task<ListTicketResp> ListTicket(ListTicketReq req, ServerCallContext ctx) {
            Payload.ListTicketResp result = _ticketUC.List(new Payload.ListTicketReq{
                ownerId = Parser.ParseGuid(req.OwnerId),
                asigneeId = Parser.ParseGuid(req.AsigneeId),
                status = req.Status,
                page = req.Page,
                limit = req.Limit,
                name = req.Name
            });
            ListTicketResp protoResult = new ListTicketResp();
            protoResult.Tickets.Add(TicketConverter.TicketEntitiesToProtos(result.tickets));
            protoResult.TotalResults = result.ticketCount;
            return Task.FromResult(protoResult);
        }
        public override Task<Ticket> CreateTicket(Ticket req, ServerCallContext ctx) {
            Entity.Ticket result = _ticketUC.Create(TicketConverter.TicketProtoToEntity(req));
            return Task.FromResult(TicketConverter.TicketEntityToProto(result));
        }
        public override Task<Ticket> UpdateTicket(Ticket req, ServerCallContext ctx) {
            Entity.Ticket result = _ticketUC.Update(TicketConverter.TicketProtoToEntity(req));
            return Task.FromResult(TicketConverter.TicketEntityToProto(result));
        }
        public override Task<Ticket> UpdateTicketAsignee(Ticket req, ServerCallContext ctx) {
            Entity.Ticket result = _ticketUC.UpdateAsignee(TicketConverter.TicketProtoToEntity(req));
            return Task.FromResult(TicketConverter.TicketEntityToProto(result));
        }
        public override Task<Ticket> UpdateTicketStatus(Ticket req, ServerCallContext ctx) {
            Entity.Ticket result = _ticketUC.UpdateStatus(TicketConverter.TicketProtoToEntity(req));
            return Task.FromResult(TicketConverter.TicketEntityToProto(result));
        }
        public override Task<Success> DeleteTicket(Ticket req, ServerCallContext ctx) {
            _ticketUC.Delete(TicketConverter.TicketProtoToEntity(req));
            return Task.FromResult(new Success{
                Success_ = true
            });
        }
    }
    #endregion
}
