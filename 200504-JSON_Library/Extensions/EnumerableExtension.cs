using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _200504_JSON_Library.Extensions
{
	public static class EnumerableExtension
	{
		public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> enumerableList)
		{
			if (!(enumerableList is null))
			{
				ObservableCollection<T> tempObservableCollection = new ObservableCollection<T>();

				foreach (var item in enumerableList)
				{
					tempObservableCollection.Add(item);
				}

				return tempObservableCollection;
			}

			return null;
		}
	}
}
