using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC.Models
{
    public class AddToCart
    {
        [Key]
        public int AddToCartId { get; set; }

        // Foreign key for IdentityUser
        public string UserId { get; set; }

        // Navigation property for the User
        [ForeignKey("UserId")]
        public IdentityUser User { get; set; }

        // Navigation property for cart details
        public ICollection<AddToCartDetails> CartDetails { get; set; }
    }
}
