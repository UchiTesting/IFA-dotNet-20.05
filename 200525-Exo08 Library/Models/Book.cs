using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _200525_Exo08_Library.Models
{
	public class Book : PropertyChangingClass
	{
		private int id;
		private string title;
		private string summary;
		private DateTime releaseDate;
		private Author ownAuthor;

		public int Id
		{
			get => id; set
			{
				if (value == id) return;

				id = value;
				OnPropertyChanged(nameof(Id));
			}
		}
		public string Title
		{
			get => title;
			set
			{
				if (value == title) return;

				title = value;
				OnPropertyChanged(nameof(Title));
			}
		}
		public string Summary
		{
			get => summary;
			set
			{
				if (value == summary) return;

				summary = value;
				OnPropertyChanged(nameof(Summary));
			}
		}
		public DateTime ReleaseDate
		{
			get => releaseDate;
			set
			{
				if (value == releaseDate) return;

				releaseDate = value;
				OnPropertyChanged(nameof(ReleaseDate));
			}
		}
		public Author OwnAuthor
		{
			get => ownAuthor;
			set
			{
				if (value == ownAuthor) return;

				ownAuthor = value;
				OnPropertyChanged(nameof(ownAuthor));
			}
		}

		private Random rnd;

		public Book()
		{
			//rnd = new Random();
			//Title = RandomString();
			//Summary = RandomString();
			//ReleaseDate = DateTime.Now;
			//OwnAuthor = new Author { Name = RandomString() };
		}

		private string RandomString(int length = 10)
		{
			StringBuilder sb = new StringBuilder();

			for (int i = 0; i < length; i++)
			{
				sb.Append(Convert.ToChar(rnd.Next(65, 90)));
			}

			return sb.ToString();
		}
	}
}
