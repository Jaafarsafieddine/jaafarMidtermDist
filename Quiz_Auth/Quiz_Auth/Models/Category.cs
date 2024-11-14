using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quiz_Auth.Models
{
    public class Category
    {
        [Key]
        public int id { get; set; }

        public string type { get; set; }

        
        public virtual ICollection<Book> Books { get; set; }
    }
}
