using Microsoft.EntityFrameworkCore;

namespace Mint.Data
{
    public class MintDbContext: DbContext
    {
        public MintDbContext(DbContextOptions<MintDbContext> options): base(options)
        {

        }
    }
}
