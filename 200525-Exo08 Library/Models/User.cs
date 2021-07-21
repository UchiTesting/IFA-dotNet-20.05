using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _200525_Exo08_Library.Helpers;

namespace _200525_Exo08_Library.Models
{
	public class User : PropertyChangingClass
	{
		int id;
		string username;
		string password;
		UserRightsEnum rights;


		public int Id { get => id; set
			{
				if (value == id) return;

				id = value;
				OnPropertyChanged(nameof(Id));
			}
		}
		public string Username
		{
			get => username;
			set
			{
				if (value == username) return;

				username = value;
				OnPropertyChanged(nameof(Username));
			}
		}
		public string Password
		{
			get => password;
			set
			{
				if (value == password) return;

				password = value;
				OnPropertyChanged(nameof(Password));
			}
		}
		public UserRightsEnum Rights
		{
			get => rights; set
			{
				if (value == rights) return;

				rights = value;
				OnPropertyChanged(nameof(Rights));
			}
		}

		public User() { }
	}
}
