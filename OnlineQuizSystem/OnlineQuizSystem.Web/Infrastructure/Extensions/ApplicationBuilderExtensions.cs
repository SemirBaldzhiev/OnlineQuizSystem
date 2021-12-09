namespace OnlineQuizSystem.Web.Infrastructure.Extensions
{
    using Microsoft.EntityFrameworkCore;
    using OnlineQuizSystem.Web.Data;

    public static class ApplicationBuilderExtensions
    {
        public static WebApplication PrepareDatabase(
           this WebApplication app)
        {
            using var serviceScope = app.Services.CreateScope();
            var services = serviceScope.ServiceProvider;

            MigrateDatabase(services);

            return app;
        }
        private static void MigrateDatabase(IServiceProvider services)
        {
            var data = services.GetRequiredService<QuizSystemDbContext>();

            data.Database.Migrate();
        }
    }
}
