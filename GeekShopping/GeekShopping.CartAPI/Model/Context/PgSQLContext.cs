using Microsoft.EntityFrameworkCore;

namespace GeekShopping.CartAPI.Model.Context
{
    public class PgSQLContext : DbContext
    {
        public PgSQLContext()
        {}

        public PgSQLContext(DbContextOptions<PgSQLContext> options) : base(options)
        {}

        public DbSet<Product> Products { get; set; }
        public DbSet<CartHeader> CartHeaders { get; set; }
        public DbSet<CartDetail> CartDetails { get; set; }
    }
}