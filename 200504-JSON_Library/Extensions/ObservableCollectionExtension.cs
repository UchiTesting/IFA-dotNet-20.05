using System;
using System.Collections.Generic;
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
	}
}
