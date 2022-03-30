using Microsoft.EntityFrameworkCore;
using Mint.Models;

namespace Mint.Data
{
    public class MintDbContext: DbContext
    {
        public MintDbContext(DbContextOptions<MintDbContext> options): base(options)
        {
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Expense> Expenses { get; set; }
    }
}
