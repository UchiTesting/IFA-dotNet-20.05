using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _200504_JSON_Library
{
	[Serializable]
	public class Book : INotifyPropertyChanged
	{
		private string _title;
		private string _author;
		private int _isbn;
		public string Title
		{
			get => _title;

			set { _title = value; NotifyPropertyChanged("Title"); }
		}

		public string Author
		{
			get => _author;
			set { _author = value; NotifyPropertyChanged("Author"); }
		}

		public int ISBN
		{
			get => _isbn;
			set { _isbn = value; NotifyPropertyChanged("ISBN"); }
		}

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

		public event PropertyChangedEventHandler PropertyChanged;

		public void NotifyPropertyChanged(string propName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
		}
	}
}
