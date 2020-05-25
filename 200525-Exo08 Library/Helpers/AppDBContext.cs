using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _200525_Exo08_Library.Models;

namespace _200525_Exo08_Library.Helpers
{
	public class AppDBContext : DbContext
	{
		public AppDBContext() { }

		public DbSet<Book> Books { get;set;}
		public DbSet<Author> Authors {get;set; }
	}
}
