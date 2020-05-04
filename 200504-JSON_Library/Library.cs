using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _200504_JSON_Library
{
	[Serializable]
	public class Library
	{
		public List<Book> Books { get; set; }

		public Library()
		{
			Books = new List<Book>();
		}

		public void AddBook(Book b)
		{
			Books.Add(b);
		}

		public void AddBook(string title, string author, int isbn)
		{
			Books.Add(new Book(title,author,isbn));
		}
	}
}
