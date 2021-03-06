using System;
using System.ComponentModel.DataAnnotations;

namespace AuthApp.Internal.Repository.Connection {
    public class BaseEntity {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;
    }
}