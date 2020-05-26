namespace TicketApp.Internal.App {
    public class Ticket {
        public UseCases uc {get;}
        public Repos repos {get;}
        public Ticket() {
            repos = new Repos();
            uc = new UseCases(repos);
        }
    }
}