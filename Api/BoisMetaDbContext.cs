using Microsoft.EntityFrameworkCore;

namespace Api
{
    public class BoisMetaDbContext : DbContext
    {
        public BoisMetaDbContext(DbContextOptions<BoisMetaDbContext> options)
        {

        }
    }
}
