using Db = TicketApp.Internal.Repository.Connection;
using TicketApp.Internal.Entity;
using TicketApp.Internal.Payload;
using TicketApp.Internal.Converter;
using Microsoft.EntityFrameworkCore;
using System;

namespace TicketApp.Internal.Repository { 
    public class TicketWriter : ITicketWriter {
        public Ticket Create(Ticket Ticket){
            using(var db = new Db.DbConnection()){
                Db.Ticket TicketModel = TicketConverter.TicketEntityToModel(Ticket);
                db.Tickets.Add(TicketModel);
                db.SaveChanges();
                return TicketConverter.TicketModelToEntity(TicketModel);
            }
        }
        public Ticket Update(Ticket Ticket){
            using(var db = new Db.DbConnection()){
                Db.Ticket TicketModel = TicketConverter.TicketEntityToModel(Ticket);
                db.Tickets.Update(TicketModel);
                db.SaveChanges();
                return TicketConverter.TicketModelToEntity(TicketModel);
            }
        }
        public void DeleteById(Guid id){
            using(var db = new Db.DbConnection()){
                Db.Ticket TicketModel = new Db.Ticket{Id = id};
                db.Entry(TicketModel).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }
    }
}