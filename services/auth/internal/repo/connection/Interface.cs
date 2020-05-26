using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace AuthApp.Internal.Repository.Connection {
    public interface IDbConnection {
        public DbSet<User> Users { get; set; }
        EntityEntry Entry(object entity);
        int SaveChanges();
    }
}