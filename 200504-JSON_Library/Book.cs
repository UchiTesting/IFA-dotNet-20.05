using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _200504_JSON_Library
{
	[Serializable]
	public class Book
	{
		public string Title { get; set; }
		public string Author { get; set; }
		public int ISBN { get; set; }

		public Book(string title, string author, int isbn)
		{
			Title = title;
			Author = author;
			ISBN = isbn;
		}

		public Book() { }

		public override string ToString()
		{
			return $"{Title} by {Author} ISBN: {ISBN}";
		}
	}
}
