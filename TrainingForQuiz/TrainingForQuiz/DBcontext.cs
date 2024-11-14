using Microsoft.EntityFrameworkCore;
using TrainingForQuiz.Models;

namespace TrainingForQuiz
{
    public class AppDBcontext :DbContext
    {
        public AppDBcontext(DbContextOptions<AppDBcontext> options) : base(options)
        {

        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Car> car { get; set; }

     /*   protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Car>().HasOne(i => i.person).WithMany(i => i.myCars).HasForeignKey(i => i.person_Id);
        } */
    }
}
