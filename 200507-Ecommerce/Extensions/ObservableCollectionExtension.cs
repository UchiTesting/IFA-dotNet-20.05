using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _200504_JSON_Library.Extensions
{
	public static class ObservableCollectionExtension
	{
		public static void ForEach<TGenericType>(this IEnumerable<TGenericType> source, Action<TGenericType> action)
		{
			foreach (TGenericType item in source)
			{
				action(item);
			}
		}

		public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> enumerable)
		{
			ObservableCollection<T> tmpObservableCollection = new ObservableCollection<T>();

			foreach (var item in enumerable)
			{
				tmpObservableCollection.Add(item);
			}

			return tmpObservableCollection;
		}
	}
}
