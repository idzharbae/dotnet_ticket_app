using TicketApp.Internal.Entity;
using TicketApp.Internal.Payload;

namespace TicketApp.Internal.UseCase {
    public interface ITicketUC {
        Ticket Get(Ticket ticket);
        ListTicketResp List(ListTicketReq req);
        
        Ticket Create(Ticket ticket);
        Ticket Update(Ticket ticket);
        Ticket UpdateAsignee(Ticket ticket);
        Ticket UpdateStatus(Ticket ticket);
        void Delete(Ticket ticket);
    }
    public interface ICategoryUC {
        Category Get(Category category);
        ListCategoryResp List(ListCategoryReq req);
        
        Category Create(Category category);
        Category Update(Category category);
        void Delete(Category category);
    }
}