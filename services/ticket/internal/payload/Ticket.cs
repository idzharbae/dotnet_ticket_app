using TicketApp.Internal.Entity;
using System;

namespace TicketApp.Internal.Payload {
    public class ListTicketReq {
        public Guid ownerId {get; set;}
        public Guid asigneeId {get; set;}
        public Guid categoryId {get; set;}
        public int status {get; set;}
        public int page {get; set;}
        public int limit {get; set;}
        public string name {get; set;}
    }
    public class ListTicketResp {
        public Ticket[] tickets {get; set;}
        public long ticketCount {get; set;}
    }
}