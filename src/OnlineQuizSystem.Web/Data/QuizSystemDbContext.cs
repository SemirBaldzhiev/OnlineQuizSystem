using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace OnlineQuizSystem.Web.Data
{
    public class QuizSystemDbContext : IdentityDbContext
    {
        public QuizSystemDbContext(DbContextOptions<QuizSystemDbContext> options)
            : base(options)
        {
        }
    }
}