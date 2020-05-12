namespace _200507_Exo07_Ecommerce.Objects
{
	public class User
	{
		public User() { }

		public User(string login, string pwd, bool isAdmin = false)
		{
			Login = login;
			Password = pwd;
			IsAdmin = isAdmin;
		}

		private string _password;
		public int Id { get; set; }
		public string Login { get; set; }
		public string Password
		{
			get => _password;
			set => _password = ScrambledPassword(_password);
		}
		public bool IsAdmin { get; set; }

		private string ScrambledPassword(string pass)
		{
			return pass; // TODO use a hash algorithm to actually scramble the real password. For now just let it clear;
		}
	}
}
