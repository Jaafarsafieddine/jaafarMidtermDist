using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class category
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; }

        
        public ICollection<Car> Cars { get; set; }
    }
}
