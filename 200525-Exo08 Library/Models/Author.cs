using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace _200525_Exo08_Library.Models
{
	public class Author : PropertyChangingClass
	{
		private int id;
		private string name;
		private ICollection<Book> writtenBooks;

		public int Id
		{
			get => id; set
			{
				if (value == id) return;

				id = value;
				OnPropertyChanged(nameof(Id));
			}
		}
		public string Name
		{
			get => name;
			set
			{
				if (value == name) return;

				name = value;
				OnPropertyChanged(nameof(Name));
			}
		}

		[InverseProperty("OwnAuthor")]
		virtual public ICollection<Book> WrittenBooks
		{
			get => writtenBooks;
			set
			{
				if (value == writtenBooks) return;

				writtenBooks = value;
				OnPropertyChanged(nameof(WrittenBooks));
			}
		}
	}
}
