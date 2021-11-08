using Infrastructure.SqlServer.Repositories.History;
using Infrastructure.SqlServer.Repositories.User;
using Infrastructure.SqlServer.Repositories.VideoGame;
using Infrastructure.SqlServer.System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Services.Services.History;
using Services.UseCases.History;
using Services.UseCases.VideoGame;

namespace WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add repos
            services.AddSingleton<IUserRepository, UserRepository>();
            services.AddSingleton<IVideoGameRepository, VideoGameRepository>();
            services.AddSingleton<IHistoryRepository, HistoryRepository>();
            services.AddSingleton<IDatabaseManager, DatabaseManager>();

            // Add services
            services.AddSingleton<IHistoryService, HistoryService>();

            // Add use cases
            services.AddSingleton<UseCaseCreateVideoGame>();
            services.AddSingleton<UseCaseCreateHistoryItem>();
            services.AddSingleton<UseCaseGenerateVideoGameReport>();

            services.AddControllers();

            services.AddSwaggerGen(c => { c.SwaggerDoc("v1", new OpenApiInfo {Title = "My API", Version = "v1"}); });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();

            app.UseSwagger();

            app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1"); });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}