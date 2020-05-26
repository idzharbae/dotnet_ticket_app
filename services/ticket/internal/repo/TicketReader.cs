using Db = TicketApp.Internal.Repository.Connection;
using TicketApp.Internal.Payload;
using TicketApp.Internal.Entity;
using TicketApp.Internal.Converter;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TicketApp.Internal.Repository { 
    public class TicketReader : ITicketReader {
        public Ticket GetById(Guid ticketId) {
            using(var db = new Db.DbConnection()){        
                Db.Ticket TicketModel = db.Tickets.Where(c => c.Id == ticketId).First();
                return TicketConverter.TicketModelToEntity(TicketModel);
            }
        }
        public ListTicketResp ListByOwnerId(ListTicketReq req) {
            using(var db = new Db.DbConnection()){        
                int limit = Math.Max(req.limit, 0);
                int offset = Math.Max((req.page-1)*limit, 0);
                
                IQueryable<Db.Ticket> query = db.Tickets.Where(t => t.OwnerId == req.ownerId);
                if(req.status != default(int))
                    query = query.Where(t => t.Status == req.status);
                if(!string.IsNullOrEmpty(req.name))
                    query = query.Where(t => EF.Functions.Like(t.Name, "%"+req.name+"%"));
                
                long resultCount = query.Count();
                Db.Ticket[] TicketModels = query.Skip(offset).Take(limit).ToArray();
                
                return new ListTicketResp{
                    tickets = TicketConverter.TicketModelsToEntities(TicketModels),
                    ticketCount = resultCount
                };
            }
        }
        public ListTicketResp ListByAsigneeId(ListTicketReq req) {
            using(var db = new Db.DbConnection()){        
                int limit = Math.Max(req.limit, 0);
                int offset = Math.Max((req.page-1)*limit, 0);

                IQueryable<Db.Ticket> query = db.Tickets.Where(t => t.AsigneeId == req.asigneeId);
                if(req.status != default(int))
                    query = query.Where(t => t.Status == req.status);
                if(!string.IsNullOrEmpty(req.name))
                    query = query.Where(t => EF.Functions.Like(t.Name, "%"+req.name+"%"));
                
                long resultCount = query.Count();
                Db.Ticket[] TicketModels = query.Skip(offset).Take(limit).ToArray();
                
                return new ListTicketResp{
                    tickets = TicketConverter.TicketModelsToEntities(TicketModels),
                    ticketCount = resultCount
                };
            }
        }
        public ListTicketResp ListAll(ListTicketReq req) {
            using(var db = new Db.DbConnection()){        
                int limit = Math.Max(req.limit, 0);
                int offset = Math.Max((req.page-1)*limit, 0);
                
                IQueryable<Db.Ticket> query = db.Tickets;
                if(req.status != default(int))
                    query = query.Where(t => t.Status == req.status);
                if(!string.IsNullOrEmpty(req.name))
                    query = query.Where(t => EF.Functions.Like(t.Name, "%"+req.name+"%"));
                
                long resultCount = query.Count();
                Db.Ticket[] TicketModels = query.Skip(offset).Take(limit).ToArray();
                
                return new ListTicketResp{
                    tickets = TicketConverter.TicketModelsToEntities(TicketModels),
                    ticketCount = resultCount
                };
            }
        }
    }
}