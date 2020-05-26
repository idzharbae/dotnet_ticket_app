using TicketApp.Internal.Entity;

namespace TicketApp.Internal.Payload {
    public class ListCategoryReq {
        public int page {get; set;}
        public int limit {get; set;}
    }
    public class ListCategoryResp {
        public Category[] categories;
        public long totalCategories;
    }
}