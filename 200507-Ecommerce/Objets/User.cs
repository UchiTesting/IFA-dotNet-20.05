using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace _200507_Ecommerce.Objets
{
	public class User
	{
		private string _password;
		public int Id { get; set; }
		public string Login { get; set; }
		public string Password
		{
			get { return _password;}
			set { _password = ScrambledPassword(_password);}
		}
		private string ScrambledPassword(string pass)
		{
			return pass; // TODO use a hash algorithm to actually scramble the real password. For now just let it clear;
		}
	}
}
