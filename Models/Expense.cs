using System.ComponentModel.DataAnnotations;

namespace Mint.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
    }
}
