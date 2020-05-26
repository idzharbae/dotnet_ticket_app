using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq;
using System;

namespace TicketApp.Internal.Repository.Connection {
    public class DbConnection :  DbContext, IDbConnection
    {
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Server=127.0.0.1,1434;Database=master;User Id=sa;Password=SUp3rS3kRet!;");
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Ticket>()
                .Property<bool>("IsDeleted");
            modelBuilder.Entity<Ticket>()
                .HasQueryFilter(post => EF.Property<bool>(post, "IsDeleted") == false);
            modelBuilder.Entity<Category>()
                .Property<bool>("IsDeleted");
            modelBuilder.Entity<Category>()
                .HasQueryFilter(post => EF.Property<bool>(post, "IsDeleted") == false);
        }
        public override int SaveChanges() {
            OnBeforeSaving();
            return base.SaveChanges();
        }
        void OnBeforeSaving() {
            foreach (var entry in ChangeTracker.Entries<Category>()) {
                MarkDeleted(entry);
            }
            foreach (var entry in ChangeTracker.Entries<Ticket>()) {
                MarkDeleted(entry);
            }
        }
        void MarkDeleted(EntityEntry entry) {
            switch (entry.State) {
                case EntityState.Added:
                    entry.CurrentValues["IsDeleted"] = false;
                    break;

                case EntityState.Deleted:
                    entry.State = EntityState.Modified;
                    entry.CurrentValues["IsDeleted"] = true;
                    break;
            }
        }
    }

    public class Ticket : BaseEntity {
        public string Name { get; set;}
        public string Description { get; set;}
        public Guid AsigneeId { get; set;}
        public Guid OwnerId { get; set;}
        public Guid CategoryId { get; set;}
        public int Status { get; set;}
    }
    public class Category : BaseEntity {
        public string Name {get; set;}
    }
}