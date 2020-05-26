using System;

namespace TicketApp.Internal.Entity
{
    public class Ticket
    {
        public Guid Id { get; set; }
        public string Name { get; set;}
        public string Description { get; set;}
        public Guid AsigneeId { get; set;}
        public Guid OwnerId { get; set;}
        public Guid CategoryId { get; set;}
        public int Status { get; set;}
        public DateTime CreatedAt {get; set;}
        public DateTime UpdatedAt {get; set;}
    }
}