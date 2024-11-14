using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace quizLearning.Models
{
    public class Person
    {
        [Key]
       public int id { get; set; }
        
        public string name { get; set; }
        public int age { get; set; }

        public List<Car> myCars { get; set; }
        

    }
}
