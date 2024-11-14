using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase_Advanced
{
    public class DataContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=JAAFAR\SQLEXPRESS;Database=Demo_Advanced;Trusted_Connection=True;TrustServerCertificate=true");
        }
    }
}
