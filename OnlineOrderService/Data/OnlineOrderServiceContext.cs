using Microsoft.EntityFrameworkCore;

namespace OnlineOrderService.Data
{
    public class OnlineOrderServiceContext : DbContext
    {
        public OnlineOrderServiceContext (DbContextOptions<OnlineOrderServiceContext> options)
            : base(options)
        {
        }

        public DbSet<OnlineOrder.Models.Order> Order { get; set; }

        public DbSet<OnlineOrder.Models.Customer> Customer { get; set; }

        public DbSet<OnlineOrder.Models.MenuItem> MenuItem { get; set; }

        public DbSet<OnlineOrder.Models.Ingredients> Ingredients { get; set; }
    }
}
