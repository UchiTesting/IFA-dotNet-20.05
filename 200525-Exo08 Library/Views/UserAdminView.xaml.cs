using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

using _200525_Exo08_Library.Helpers;
using _200525_Exo08_Library.Models;

namespace _200525_Exo08_Library.Views
{
	/// <summary>
	/// Interaction logic for UserAdminView.xaml
	/// </summary>
	public partial class UserAdminView : Page
	{
		AppDBContext db;
		public UserAdminView()
		{
			InitializeComponent();
			db = new AppDBContext();

			LvUsers.ItemsSource = db.Users.Local;
			db.Users.Load();

			CbxRights.ItemsSource = Enum.GetValues(typeof(UserRightsEnum));
		}

		private void BtnAdd_Click(object sender, RoutedEventArgs e)
		{
			User nu = new User();

			nu.Username = TbxUsername.Text;
			nu.Password = TbxPassword.Text;
			nu.Rights = (UserRightsEnum)CbxRights.SelectedIndex;
			db.Users.Add(nu);
			db.SaveChanges();
		}

		private void BtnUpdate_Click(object sender, RoutedEventArgs e)
		{
			User nu = LvUsers.SelectedItem as User;
			if (nu is null) return;

			nu.Username = TbxUsername.Text;
			nu.Password = TbxPassword.Text;
			nu.Rights = (UserRightsEnum)CbxRights.SelectedIndex;
			
			db.SaveChanges();

		}

		private void BtnRemove_Click(object sender, RoutedEventArgs e)
		{
			User nu = LvUsers.SelectedItem as User;
			if (nu is null) return;

			db.Users.Remove(nu);
			db.SaveChanges();
		}

		private void LvUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			User nu = LvUsers.SelectedItem as User;
			if (nu is null) return;

			TbxUsername.Text = nu.Username;
			TbxPassword.Text = nu.Password;
			CbxRights.SelectedIndex = (int)nu.Rights;
		}
	}
}
