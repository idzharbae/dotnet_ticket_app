using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace TicketApp.Internal.Repository.Connection {
    public interface IDbConnection {
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Category> Categories { get; set; }
        EntityEntry Entry(object entity);
        int SaveChanges();
    }
}