using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Mint.Models
{
    public class ExpenseCategory
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
