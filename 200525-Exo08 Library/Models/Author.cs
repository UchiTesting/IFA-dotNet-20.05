using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _200525_Exo08_Library.Models
{
	public class Author : PropertyChangingClass
	{
		private int id;
		private string name;

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
	}
}
