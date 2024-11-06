using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Store.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]

        [MaxLength(20)]
        [DisplayName("Name")]
        public string Name { get; set; }

        [DisplayName("RollNo")]
        [MaxLength(10)]
        public int RollNo { get; set; }
    }
}
