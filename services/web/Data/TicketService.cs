using System;
using System.Linq;
using System.Threading.Tasks;
using TicketGrpc = TicketApp.Internal.Delivery.Grpc;
using AuthGrpc = AuthApp.Internal.Delivery.Grpc;
using Grpc.Net.Client;
using StateManagement;

namespace web.Data
{
    public class TicketService {
        TicketGrpc.TicketGrpc.TicketGrpcClient ticketClient;
        AuthGrpc.AuthGrpc.AuthGrpcClient authClient;
        public TicketService(AuthGrpc.AuthGrpc.AuthGrpcClient authClient, 
            TicketGrpc.TicketGrpc.TicketGrpcClient ticketClient) {
            this.ticketClient = ticketClient;
            this.authClient = authClient;
        }
        public Ticket CreateTicket(Ticket req, string jwt) {
            var user = authClient.GetUserFromToken(new AuthGrpc.Token{
                Token_ = jwt
            });
            if(!string.IsNullOrEmpty(req.Asignee)) {
                var asignee = authClient.GetUserByEmail(new AuthGrpc.GetUserByEmailReq{
                    Email = req.Asignee
                });
                req.Asignee = asignee.Id;
            }
            var ticket = ticketClient.CreateTicket(new TicketGrpc.Ticket{
                Name = req.Name,
                Description = req.Description,
                OwnerId = user.Id,
                AsigneeId = req.Asignee,
                Status = req.Status,
                CategoryId = req.Category
            });
            string category = "";
            if(ticket.CategoryId != default(Guid).ToString()) {
                TicketGrpc.Category cat = ticketClient.GetCategory(new TicketGrpc.Category{
                    Id = ticket.CategoryId
                });
                category = cat.Name;
            }
            req.Category = category;
            req.Id = ticket.Id;
            req.CreatedAt = UnixTimeStampToDateTime(ticket.CreatedAt).ToString();
            req.UpdatedAt = UnixTimeStampToDateTime(ticket.UpdatedAt).ToString();
            return req;
        }
        public Ticket UpdateTicket(Ticket req, string jwt) {
            var user = authClient.GetUserFromToken(new AuthGrpc.Token{
                Token_ = jwt
            });

            if(!string.IsNullOrEmpty(req.Asignee)) {
                var asignee = authClient.GetUserByEmail(new AuthGrpc.GetUserByEmailReq{
                    Email = req.Asignee
                });
                req.Asignee = asignee.Id;
            }
            var ticket = ticketClient.UpdateTicket(new TicketGrpc.Ticket{
                Id = req.Id,
                Name = req.Name,
                Description = req.Description,
                OwnerId = user.Id,
                AsigneeId = req.Asignee,
                Status = req.Status,
                CategoryId = req.Category
            });
            string category = "";
            if(ticket.CategoryId != default(Guid).ToString()) {
                TicketGrpc.Category cat = ticketClient.GetCategory(new TicketGrpc.Category{
                    Id = ticket.CategoryId
                });
                category = cat.Name;
            }
            req.Category = category;
            req.Id = ticket.Id;
            req.CreatedAt = UnixTimeStampToDateTime(ticket.CreatedAt).ToString();
            req.UpdatedAt = UnixTimeStampToDateTime(ticket.UpdatedAt).ToString();
            return req;
        }
        public Ticket UpdateTicketStatus(Ticket req, string jwt) {
            var user = authClient.GetUserFromToken(new AuthGrpc.Token{
                Token_ = jwt
            });
            var ticket = ticketClient.UpdateTicketStatus(new TicketGrpc.Ticket{
                Id = req.Id,
                Status = req.Status,
                AsigneeId = user.Id
            });
            string category = "";
            if(ticket.CategoryId != default(Guid).ToString()) {
                TicketGrpc.Category cat = ticketClient.GetCategory(new TicketGrpc.Category{
                    Id = ticket.CategoryId
                });
                category = cat.Name;
            }
            return new Ticket {
                Id = ticket.Id,
                Name = ticket.Name,
                Description = ticket.Description,
                Owner = req.Owner,
                Asignee = req.Asignee,
                Category = category,
                CreatedAt = UnixTimeStampToDateTime(ticket.CreatedAt).ToString(),
                UpdatedAt = UnixTimeStampToDateTime(ticket.UpdatedAt).ToString(),
            };
        }
        public void DeleteTicket(Ticket req, string jwt) {
            var user = authClient.GetUserFromToken(new AuthGrpc.Token{
                Token_ = jwt
            });
            ticketClient.DeleteTicket(new TicketGrpc.Ticket{
                Id = req.Id,
                OwnerId = user.Id
            });
        }
        public TicketList List(TicketGrpc.ListTicketReq req) {
            var resp = ticketClient.ListTicket(req);
            TicketList ticketList = new TicketList();
            TicketGrpc.Ticket[] tickets = resp.Tickets.ToArray();
            ticketList.tickets = new Ticket[tickets.Length];
            ticketList.ticketCount = resp.TotalResults;
            for(int i = 0; i < tickets.Length; i++) {
                ticketList.tickets[i] = new Ticket{};

                TicketGrpc.Ticket ticket = tickets[i];
                AuthGrpc.User owner = authClient.GetUserById(new AuthGrpc.GetUserByIdReq{
                    Id = ticket.OwnerId
                });
                ticketList.tickets[i].Owner = owner.Email;
                if(ticket.AsigneeId != default(Guid).ToString()) {
                    AuthGrpc.User asignee = authClient.GetUserById(new AuthGrpc.GetUserByIdReq{
                        Id = ticket.AsigneeId
                    });
                    ticketList.tickets[i].Asignee = asignee.Email;
                }
                if(ticket.CategoryId != default(Guid).ToString()) {
                    TicketGrpc.Category category = ticketClient.GetCategory(new TicketGrpc.Category{
                        Id = ticket.CategoryId
                    });
                    ticketList.tickets[i].Category = category.Name;
                }

                ticketList.tickets[i].CreatedAt = UnixTimeStampToDateTime(ticket.CreatedAt).ToString();
                ticketList.tickets[i].Name = ticket.Name;
                ticketList.tickets[i].Description = ticket.Description;
                ticketList.tickets[i].Status = ticket.Status;
                ticketList.tickets[i].Id = ticket.Id.ToString();
            }

            return ticketList;
        }
        public CategoryList ListCategory(TicketGrpc.ListCategoryReq req) {
            var resp = ticketClient.ListCategory(req);
            CategoryList categoryList = new CategoryList();
            TicketGrpc.Category[] categories = resp.Categories.ToArray();
            categoryList.categories = new Category[categories.Length];
            categoryList.categoryCount = resp.TotalResults;
            for(int i = 0; i < categories.Length; i++) 
                categoryList.categories[i] = new Category{
                    Id = categories[i].Id,
                    Name = categories[i].Name,
                    CreatedAt = UnixTimeStampToDateTime(categories[i].CreatedAt).ToString()
                };
            return categoryList;
        }
        public Category CreateCategory(TicketGrpc.Category req, string jwt) {
            var user = authClient.GetUserFromToken(new AuthGrpc.Token{
                Token_ = jwt
            });
            var resp = ticketClient.CreateCategory(req);
            return new Category{
                Id = resp.Id,
                Name = resp.Name,
                CreatedAt = UnixTimeStampToDateTime(resp.CreatedAt).ToString()
            };
        }
        public Category UpdateCategory(TicketGrpc.Category req, string jwt) {
            var user = authClient.GetUserFromToken(new AuthGrpc.Token{
                Token_ = jwt
            });
            var resp = ticketClient.UpdateCategory(req);
            return new Category {
                Id = resp.Id,
                Name = resp.Name,
                CreatedAt = UnixTimeStampToDateTime(resp.CreatedAt).ToString()
            };
        }
        public void DeleteCategory(string categoryId, string jwt) {
            var user = authClient.GetUserFromToken(new AuthGrpc.Token{
                Token_ = jwt
            });
            ticketClient.DeleteCategory(new TicketGrpc.Category{
                Id = categoryId
            });
        }
        public static DateTime UnixTimeStampToDateTime( long unixTimeStamp ) {
            System.DateTime dtDateTime = new DateTime(1970,1,1,0,0,0,0,System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds( unixTimeStamp ).ToLocalTime();
            return dtDateTime;
        }
    }
    public class TicketList {
        public Ticket[] tickets;
        public long ticketCount;
    }
    public class CategoryList {
        public Category[] categories;
        public long categoryCount;
    }
    public class Modal {
        public string ModalDisplay = "none;";
        public string ModalClass = "";
        public bool ShowBackdrop = false;
        public string Name = "";
        public void Open(string Name) {
            ModalDisplay = "block;";
            ModalClass = "Show";
            this.Name = Name;
            ShowBackdrop = true;
        }
        public void Close() {
            ModalDisplay = "none";
            ModalClass = "";
            ShowBackdrop = false;
        }
    }
    public class TicketModal : Modal {

    }
    public class CategoryModal : Modal {
        
    }
}
