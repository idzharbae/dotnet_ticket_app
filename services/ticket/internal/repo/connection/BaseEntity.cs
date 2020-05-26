using System;
using System.ComponentModel.DataAnnotations;

namespace TicketApp.Internal.Repository.Connection {
    public class BaseEntity {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}