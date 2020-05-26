using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using web.Data;
using AuthApp.Internal.Delivery.Grpc;
using TicketApp.Internal.Delivery.Grpc;
using Grpc.Net.Client;
using Grpc.Net.Client.Web;
using System.Net.Http;
using StateManagement;

namespace web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();

            // Grpc clients
            var authChannel = GrpcChannel.ForAddress("http://localhost:5001");
            AuthGrpc.AuthGrpcClient authClient = new AuthGrpc.AuthGrpcClient(authChannel);
            var ticketChannel = GrpcChannel.ForAddress("http://localhost:5002");
            TicketGrpc.TicketGrpcClient ticketClient =  new TicketGrpc.TicketGrpcClient(ticketChannel);
            services.AddSingleton<AuthService>(new AuthService(authClient));
            services.AddSingleton<TicketService>(new TicketService(authClient, ticketClient));
            
            services.AddScoped<JwtState>();
            services.AddScoped<UserState>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
