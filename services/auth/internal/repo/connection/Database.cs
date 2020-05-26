using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;

namespace AuthApp.Internal.Repository.Connection {
    public class DbConnection :  DbContext
    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Server=127.0.0.1,1433;Database=master;User Id=sa;Password=SUp3rS3kRet!;");
        protected override void OnModelCreating(ModelBuilder builder){
            builder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();
        }
        public override int SaveChanges() {
            foreach (var entry in ChangeTracker.Entries().Where(x => x.Entity.GetType().GetProperty("CreatedAt") != null)) {
                if (entry.State == EntityState.Added)
                    entry.Property("CreatedAt").CurrentValue = DateTime.Now;
                else if (entry.State == EntityState.Modified)
                    entry.Property("CreatedAt").IsModified = false;
                entry.Property("UpdatedAt").CurrentValue = DateTime.Now;
            }
            return base.SaveChanges();
        }
    }

    public class User : BaseEntity {
        public string Email {get; set; }
        public string FullName {get; set;}
        public string Password {get; set;}
    }
}