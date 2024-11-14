using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingForQuiz.Models
{
    public class Car
    {
        /*
        [Key]
        public int Id { get; set; }  

        public string Name { get; set; }

        
        public int person_Id { get; set; }
        
        public virtual Person person { get; set; }

        public DateTime ModelYear { get; set; }   */

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [ForeignKey("Owner")]
        public int OwnerId { get; set; }

        
        [ForeignKey("OwnerId")]
        public Person Owner { get; set; }

        public DateTime ModelYear { get; set; }
    }
}
