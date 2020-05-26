using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using App = TicketApp.Internal.App;
using TicketApp.Internal.UseCase;

namespace TicketApp.Internal.Delivery.Grpc {
    #region snippet
    public class GrpcStartup {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        
        public void ConfigureServices(IServiceCollection services) {
            services.AddGrpc();
            var ticket = new App.Ticket();
            services.AddSingleton<ITicketUC>(ticket.uc.ticketUC);
            services.AddSingleton<ICategoryUC>(ticket.uc.categoryUC);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints => {
                // Communication with gRPC endpoints must be made through a gRPC client.
                // To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909
                endpoints.MapGrpcService<TicketService>();
            });
            
        }
    }
    #endregion
}
