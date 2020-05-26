using TicketApp.Internal.Repository;
using TicketApp.Internal.Entity;
using TicketApp.Internal.Payload;
using Db = TicketApp.Internal.Repository.Connection;
using Grpc.Core;
using System;

namespace TicketApp.Internal.UseCase {
    public class TicketUC : ITicketUC {
        ITicketReader ticketReader;
        ITicketWriter ticketWriter;
        public TicketUC(ITicketReader ticketReader, ITicketWriter ticketWriter) {
            this.ticketReader = ticketReader;
            this.ticketWriter = ticketWriter;
        }
        public Ticket Get(Ticket ticket) {
            return ticketReader.GetById(ticket.Id);
        }
        public ListTicketResp List(ListTicketReq req) {
            ListTicketResp result;
            if(req.asigneeId != default(Guid))
                result = ticketReader.ListByAsigneeId(req);
            else if(req.ownerId != default(Guid))
                result = ticketReader.ListByOwnerId(req);
            else result = ticketReader.ListAll(req);

            return result;
        }
        public Ticket Create(Ticket ticket) {
            ticket.Id = default(Guid);
            ticket.CreatedAt = DateTime.Now;
            ticket.UpdatedAt = DateTime.Now;
            return ticketWriter.Create(ticket);
        }
        public Ticket Update(Ticket ticket) {
            Ticket savedTicket = ticketReader.GetById(ticket.Id);
            if(savedTicket.OwnerId != ticket.OwnerId)
                throw new RpcException(new Status(StatusCode.PermissionDenied, 
                    "user is not authorized to update this ticket."), "");
            ticket.CreatedAt = savedTicket.CreatedAt;
            ticket.UpdatedAt = DateTime.Now;
            return ticketWriter.Update(ticket);
        }
        public Ticket UpdateAsignee(Ticket ticket) {
            Ticket savedTicket = ticketReader.GetById(ticket.Id);
            if(savedTicket.OwnerId != ticket.OwnerId)
                throw new RpcException(new Status(StatusCode.PermissionDenied, 
                    "user is not authorized to update this ticket."), "");
            savedTicket.AsigneeId = ticket.AsigneeId;
            savedTicket.UpdatedAt = DateTime.Now;
            return ticketWriter.Update(savedTicket);
        }
        public Ticket UpdateStatus(Ticket ticket) {
            Ticket savedTicket = ticketReader.GetById(ticket.Id);
            if(savedTicket.OwnerId != ticket.OwnerId && savedTicket.AsigneeId != ticket.AsigneeId)
                throw new RpcException(new Status(StatusCode.PermissionDenied, 
                    "user is not authorized to update this ticket."), "");
            savedTicket.Status = ticket.Status;
            savedTicket.UpdatedAt = DateTime.Now;
            return ticketWriter.Update(savedTicket);
        }
        public void Delete(Ticket ticket) {
            Ticket savedTicket = ticketReader.GetById(ticket.Id);
            if(savedTicket.OwnerId != ticket.OwnerId)
                throw new RpcException(new Status(StatusCode.PermissionDenied, 
                    "user is not authorized to update this ticket."), "");
            
            ticketWriter.DeleteById(savedTicket.Id);
        }
    }
}