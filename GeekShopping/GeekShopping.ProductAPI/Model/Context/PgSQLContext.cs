using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class PgSQLContext : DbContext
    {
        public PgSQLContext()
        {}

        public PgSQLContext(DbContextOptions<PgSQLContext> options) : base(options)
        {}

        public DbSet<Product> Products { get; set; }
    }
}
