using System.Collections.Generic;

namespace web.Data {
    public class Ticket {
        public string Id { get; set; } = "";
        public string Name { get; set;} = "";
        public string Description { get; set;} = "";
        public string Asignee { get; set;} = "";
        public string Owner { get; set;} = "";
        public string Category { get; set;} = "";
        public int Status { get; set;} = 0;
        public string StatusString {get {
            Dictionary<int, string> d = new Dictionary<int, string>{
                {0, ""},
                {1, "open"},
                {2, "on progress"},
                {3, "done"},
                {4, "closed"},
            };
            return d[Status];
        }}
        public string CreatedAt {get; set;}
        public string UpdatedAt {get; set;}
    }
}