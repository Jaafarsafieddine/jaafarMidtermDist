using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class AddToCartDetails
    {
        [Key]
        public int AddToCartDetailsId { get; set; }
        public int AddToCartId { get; set; }
        public string CarId { get; set; }
        public int Quantity { get; set; }

        // Navigation properties
        [ForeignKey("CarId")]
        public Car Car { get; set; }

        [ForeignKey("AddToCartId")]
        public AddToCart AddToCart { get; set; }
    }
}
