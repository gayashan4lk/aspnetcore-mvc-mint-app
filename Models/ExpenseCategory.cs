using System.ComponentModel.DataAnnotations;

namespace Mint.Models
{
    public class ExpenseCategory
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
