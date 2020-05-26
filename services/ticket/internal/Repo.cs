using TicketApp.Internal.Entity;
using TicketApp.Internal.Payload;
using System;

namespace TicketApp.Internal.Repository {
    public interface ITicketReader{
        Ticket GetById(Guid ticketId);
        ListTicketResp ListAll(ListTicketReq req);
        ListTicketResp ListByOwnerId(ListTicketReq req);
        ListTicketResp ListByAsigneeId(ListTicketReq req);
    }
    public interface ITicketWriter {
        Ticket Create(Ticket Ticket);
        Ticket Update(Ticket Ticket);
        void DeleteById(Guid id);
    }
    public interface ICategoryReader{
        long CountCategories();
        Category GetById(Guid categoryId);
        Category[] List(ListCategoryReq req);
    }
    public interface ICategoryWriter {
        Category Create(Category category);
        Category Update(Category category);
        void DeleteById(Guid id);
    }
}