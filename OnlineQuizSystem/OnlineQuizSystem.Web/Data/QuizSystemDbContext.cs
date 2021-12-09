namespace OnlineQuizSystem.Web.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using OnlineQuizSystem.Web.Data.Models;

    public class QuizSystemDbContext : IdentityDbContext
    {
        public QuizSystemDbContext(DbContextOptions<QuizSystemDbContext> options)
            : base(options)
        {
        }

        public DbSet<Answer> Answers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
    }
}