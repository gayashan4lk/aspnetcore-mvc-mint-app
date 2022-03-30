using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Mint.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Amount should be greater than 0 !")]
        public double Amount { get; set; }
        [Required]
        [DisplayName("Expense category")]
        public string ExpenseCategory { get; set; }
    }
}
