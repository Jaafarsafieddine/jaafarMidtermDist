using Microsoft.EntityFrameworkCore;
using quizLearning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizLearning
{
    public class DBcontext : DbContext
    {
        public DBcontext(DbContextOptions<DBcontext> options) : base(options)
        {

        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Car> car { get; set; }
        

        


    }

}

