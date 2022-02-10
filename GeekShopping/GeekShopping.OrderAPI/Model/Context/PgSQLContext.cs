using Microsoft.EntityFrameworkCore;

namespace GeekShopping.OrderAPI.Model.Context
{
    public class PgSQLContext : DbContext
    {
        public PgSQLContext()
        {}

        public PgSQLContext(DbContextOptions<PgSQLContext> options) : base(options)
        {}

        public DbSet<OrderHeader> Headers { get; set; }
        public DbSet<OrderDetail> Details { get; set; }
    }
}