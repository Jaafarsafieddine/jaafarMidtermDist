using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quiz_Auth.Models
{
    public class Book
    {
        [Key]
        public int id { set; get; }
        public string name { set; get; }
        [ForeignKey("category_id")]
        public int category_id { set;get; }

        public Category category { set; get; }
    }
}
