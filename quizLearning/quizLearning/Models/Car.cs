using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
namespace quizLearning.Models
{
    public class Car
    {
        [Key]
        public int id { get; set; }
        public string modelName { get; set; }
        public DateFormat modelYear { get; set; }
    }
}
