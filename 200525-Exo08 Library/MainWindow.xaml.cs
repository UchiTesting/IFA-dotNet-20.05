using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using _200525_Exo08_Library.Views;

namespace _200525_Exo08_Library
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{


		/// <summary>
		/// 
		/// </summary>
		/// 
		User currentUser;
		public MainWindow()
		{
			InitializeComponent();
			LoginWindow loginWindow = new LoginWindow();
			this.WindowStartupLocation = WindowStartupLocation.CenterScreen;

			if (loginWindow.ShowDialog() == true)
			{
				currentUser = loginWindow.loggedUser;
				MessageBox.Show($"Current User: {currentUser.Username} is {currentUser.Rights}","Test");
			}

			InitializeTabs();

		}

		private void InitializeTabs()
        {
			if (currentUser.Rights >= UserRightsEnum.EDITOR)
            {
				TimAuthors.Visibility = Visibility.Visible;
            }

			if (currentUser.Rights >= UserRightsEnum.ADMIN)
            {
				TimUsers.Visibility = Visibility.Visible;
            }

        }

	}
}
