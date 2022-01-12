using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Application.UseCases.Parcours;
using Application.UseCases.Personnes;
using Application.UseCases.Sessions;
using Infrastructure.SqlServer.Repositories.Parcours;
using Infrastructure.SqlServer.Repositories.Personne;
using Infrastructure.SqlServer.Repositories.Session;
using Infrastructure.SqlServer.System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace WebAPI
{
    public class Startup
    {
        private static readonly string MyOrigins = "MyOrigins";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(MyOrigins, builder =>
                {
                    builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader();
                });
            });

            /* Repositories */
            services.AddSingleton<IDatabaseManager, DatabaseManager>();
            services.AddSingleton<IPersonneRepository, PersonneRepository>();
            services.AddSingleton<IParcoursRepository, ParcoursRepository>();
            services.AddSingleton<ISessionRepository, SessionRepository>();

            /* Factories */
            services.AddSingleton<PersonneFactory>();
            services.AddSingleton<ParcoursFactory>();
            services.AddSingleton<SessionFactory>();

            /* Use Cases */
            services.AddSingleton<UseCaseCreatePersonne>();
            services.AddSingleton<UseCaseGetAllPersonnes>();
            services.AddSingleton<UseCaseGetByIdPersonne>();

            services.AddSingleton<UseCaseCreateParcours>();
            services.AddSingleton<UseCaseGetAllParcours>();
            services.AddSingleton<UseCaseGetByIdParcours>();

            services.AddSingleton<UseCaseCreateSession>();
            services.AddSingleton<UseCaseGetAllSessions>();
            services.AddSingleton<UseCaseGetByIdSession>();

            /* Validators */

            /* Base functions */
            services.AddControllers();
            services.AddSwaggerGen();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            else
            {
                app.UseHttpsRedirection();
            }

            app.UseCors(MyOrigins);

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}
