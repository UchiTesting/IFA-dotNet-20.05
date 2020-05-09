using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _200506_Exo06_Blog.Enums;

namespace _200506_Exo06_Blog.Objects
{
	public class User : INotifyPropertyChanged
	{
		UserRightsEnum _priviledge;
		string _login;
		string _password;

		public UserRightsEnum Priviledge
		{
			get { return _priviledge; }
			set { _priviledge = value; NotifyPropertyChanged("Priviledge"); }
		}
		public string Login
		{
			get { return _login; }
			set { _login = value; NotifyPropertyChanged("Login"); }
		}
		public string Password
		{
			get { return _password; }
			set { _password = value; NotifyPropertyChanged("Password"); }
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public void NotifyPropertyChanged(string propName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
		}

		public override string ToString()
		{
			return $"{Login} as {Priviledge}";
		}
	}
}
