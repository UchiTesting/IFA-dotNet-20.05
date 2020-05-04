using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;


namespace _200504_JSON_Library
{
	class LibrarySerializer
	{
		private readonly string _path;
		public List<Book> Books { get; set; }

		public LibrarySerializer(string path)
		{
			_path = path;
			Books = new List<Book>();
		}

		public void Load()
		{
			string jsonString = File.ReadAllText(_path);
			Books = JsonSerializer.Deserialize<List<Book>>(jsonString);
		}

		public void Save()
		{
			string jsonString = JsonSerializer.Serialize(Books);
			File.WriteAllText(_path,jsonString);
		}

		public string DisplayBooksAsString()
		{
			StringBuilder sb = new StringBuilder();

			Books.ForEach(b => sb.AppendLine(b.ToString()));

			return sb.ToString();
		}

	}
}
