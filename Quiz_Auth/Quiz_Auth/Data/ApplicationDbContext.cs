using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Quiz_Auth.Models;

namespace Quiz_Auth.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Quiz_Auth.Models.Book> Book { get; set; } = default!;
        public DbSet<Quiz_Auth.Models.Category> Category { get; set; } = default!;
    }
}
