using TicketApp.Internal.Repository.Connection;
using TicketApp.Internal.Repository;
using Microsoft.EntityFrameworkCore;

namespace TicketApp.Internal.App {
    
    public class Repos {
        IDbConnection db;
        public ITicketReader ticketReader {get;}
        public ITicketWriter ticketWriter {get;}
        public ICategoryReader categoryReader {get;}
        public ICategoryWriter categoryWriter {get;}
        public Repos(){
            ticketReader = new TicketReader();
            ticketWriter = new TicketWriter();
            categoryReader = new CategoryReader();
            categoryWriter = new CategoryWriter();
        }
    }
}