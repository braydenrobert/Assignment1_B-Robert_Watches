using Assignment1_B_Robert_WatchesRemake.Models;
using Microsoft.EntityFrameworkCore;
using Assignment1_B_Robert_WatchesRemake;

namespace Assignment1_B_Robert_WatchesRemake.Data
{
    public class BRobertWatches : DbContext
    {
        public BRobertWatches(DbContextOptions<BRobertWatches> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
