using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class Purchase
    {
        [Key]
        public int PurchaseCarId { get; set; }
        public string CarId { get; set; }
        public int Quantity { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string CarModel { get; set; }
        public string CarImage { get; set; }
        public string CarName { get; set; }

        // Foreign key for IdentityUser
        public string UserId { get; set; }

        // Navigation property for the User
        [ForeignKey("UserId")]
        public IdentityUser User { get; set; }

        // Navigation property for the Car
        [ForeignKey("CarId")]
        public Car Car { get; set; }
    }
}
