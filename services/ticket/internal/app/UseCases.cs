using TicketApp.Internal.UseCase;

namespace TicketApp.Internal.App {
    public class UseCases {
        public ITicketUC ticketUC {get;}
        public ICategoryUC categoryUC {get;}
        public UseCases(Repos repos) {
            ticketUC = new TicketUC(repos.ticketReader, repos.ticketWriter);
            categoryUC = new CategoryUC(repos.categoryReader, repos.categoryWriter);
        }
    }
}