using System.ComponentModel.DataAnnotations;

namespace TrainingForQuiz.Models
{
    public class Person
    {
        [Key]
        public int id { set; get; }
        public string name { set; get; }
        public virtual ICollection<Car> ?myCars { get; set; }
    }
}
