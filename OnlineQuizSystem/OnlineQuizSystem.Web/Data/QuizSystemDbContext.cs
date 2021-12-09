namespace OnlineQuizSystem.Web.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    public class QuizSystemDbContext : IdentityDbContext
    {
        public QuizSystemDbContext(DbContextOptions<QuizSystemDbContext> options)
            : base(options)
        {
        }
    }
}