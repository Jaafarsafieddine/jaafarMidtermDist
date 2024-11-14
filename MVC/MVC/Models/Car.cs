using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC.Models
{
    public class Car
    {
        [Key]
        public string CarId { get; set; }
        public int CategoryId { get; set; } 
        public int Year { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
        public string CarImageUrl { get; set; }
        public string CarName { get; set; }
        public string Type { get; set; }
        public string CarColor { get; set; }

        
        [ForeignKey("CategoryId")]
        public category Category { get; set; }
        public ICollection<AddToCartDetails> CartDetails { get; set; }
        public ICollection<Purchase> Purchases { get; set; }
    }
}
