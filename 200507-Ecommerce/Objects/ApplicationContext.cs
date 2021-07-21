using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _200507_Exo07_Ecommerce.Objects
{
	public class ApplicationContext : DbContext
	{
		public ApplicationContext() { }
		public DbSet<User> Users { get; set; }
		public DbSet<Cart> Carts { get; set; }
		public DbSet<Product> Products { get; set; }
	}
}
