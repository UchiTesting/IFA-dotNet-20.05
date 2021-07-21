using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _200507_Exo07_Ecommerce.Extensions
{
	public static class DbContextExtension
	{
		public static bool Exists<T>(this DbSet dbSet, T myObject)
		{
			var tmp = (T) dbSet.Find(myObject);

			return tmp != null;
		}

		public static bool Exists<T>(this DbSet<T> dbSet, T myObject) where T : class
		{
			var tmp = (T) dbSet.ToList().Find(o => o.Equals(myObject));

			return tmp != null;
		}

		public static void ForEach<T>(this DbSet<T> dbSet, Action<T> action) where T : class
		{
			foreach (var item in dbSet)
			{
				action(item);
			}
		}

		public static ObservableCollection<T> ToObservableCollection<T>(this DbSet<T> dbSet) where T : class
		{
			if (!(dbSet is null))
			{
				ObservableCollection<T> tempObservableCollection = new ObservableCollection<T>();

				foreach (var item in dbSet)
				{
					tempObservableCollection.Add(item);
				}

				return tempObservableCollection;
			}

			return null;
		}  
	}
}
