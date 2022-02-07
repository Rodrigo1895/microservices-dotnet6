using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.IdentityServer.Model.Context
{
	public class PgSQLContext : IdentityDbContext<ApplicationUser>
	{

		public PgSQLContext(DbContextOptions<PgSQLContext> options) : base(options)
		{ }
	}
}