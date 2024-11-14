using Microsoft.EntityFrameworkCore;

namespace QuizDotNet
{
    public class AppDBcontext : DbContext
    {
        public AppDBcontext(DbContextOptions<AppDBcontext> options) : base(options)
        {

        }
    }
}
