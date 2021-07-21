using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using _200525_Exo08_Library.Helpers;
using _200525_Exo08_Library.Models;

namespace _200525_Exo08_Library.Views
{
	/// <summary>
	/// Interaction logic for LoginWindow.xaml
	/// </summary>
	public partial class LoginWindow : Window
	{
		AppDBContext db;
		public User loggedUser;
		public LoginWindow()
		{
			InitializeComponent();
			db = new AppDBContext();

			this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
		}

		private void BtnValidate_Click(object sender, RoutedEventArgs e)
		{

			loggedUser = (from u in db.Users
						  where u.Username == TbxUsername.Text && u.Password == TbxPassword.Text
						  select u).FirstOrDefault();

			if (loggedUser is null)
			{
				LblErrorMsg.Content = "Wrong credentials";
			}
			else
			{
				this.DialogResult = true;
				this.Close();
			}
		}

		private void BtnValidate_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			if (TbxUsername.Text == "" || TbxPassword.Text == "")
				e.CanExecute = false;
			else
				e.CanExecute = true;
		}

		private void BtnQuit_Click(object sender, RoutedEventArgs e)
		{
			App.Current.Shutdown();
		}
	}
}
