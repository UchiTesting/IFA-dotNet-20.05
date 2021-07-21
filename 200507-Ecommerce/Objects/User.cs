using System.ComponentModel;

namespace _200507_Exo07_Ecommerce.Objects
{
	public class User : INotifyPropertyChanged
	{
		public User() { }

		public User(string login, string pwd, bool isAdmin = false)
		{
			Login = login;
			Password = pwd;
			IsAdmin = isAdmin;
		}

		private int _id;
		private string _login;
		private string _password;
		private bool _isAdmin;

		public event PropertyChangedEventHandler PropertyChanged;

		public void NotifyPropertyChanged(string propName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
		}

		public int Id { get => _id;
			set { if (_id != value) _id = value; NotifyPropertyChanged("Id"); } }
		public string Login { get => _login;
			set { if (_login != value) _login = value; NotifyPropertyChanged("Login"); } }
		public string Password { get => _password;
			set { if (_password != value) _password = ScramblePassword(value); NotifyPropertyChanged("Password"); } }
		public bool IsAdmin { get => _isAdmin;
			set { if (_isAdmin != value) _isAdmin = value; NotifyPropertyChanged("IsAdmin"); } }

		private string ScramblePassword(string pass)
		{
			return pass; // TODO use a hash algorithm to actually scramble the real password. For now just let it clear;
		}

		public override bool Equals(object obj)
		{
			var compUser = ((User)obj);

			return compUser != null
					 && compUser.GetType() == this.GetType()
					 && (compUser.Login.Equals(Login))
					 && (compUser.Password.Equals(Password));
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override string ToString()
		{
			return $"{Login} p:{Password} a:{IsAdmin}";
		}
	}
}
