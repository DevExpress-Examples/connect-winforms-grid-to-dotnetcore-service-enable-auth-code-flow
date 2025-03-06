using Microsoft.EntityFrameworkCore;

namespace DataService
{
    public class DataServiceDbContext : DbContext
    {
        public DataServiceDbContext(DbContextOptions<DataServiceDbContext> options)
            : base(options) { }

        public DbSet<OrderItem> OrderItems { get; set; }
    }
}
