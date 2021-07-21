using System;
using System.Collections.Generic;
using System.IO;
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
using _200507_Ecommerce;
using _200507_Exo07_Ecommerce.Objects;

namespace _200507_Exo07_Ecommerce.UI
{
	/// <summary>
	/// Logique d'interaction pour LoginPage.xaml
	/// </summary>
	public partial class LoginPage : Page
	{
		private MainWindow mw;

		public LoginPage()
		{
			InitializeComponent();
			mw = ((MainWindow)App.Current.MainWindow);
		}

		private void TbxLogin_GotFocus(object sender, RoutedEventArgs e)
		{
			if (TbxLogin.Text == "Login")
				TbxLogin.Text = "";
		}

		private void TbxPassword_GotFocus(object sender, RoutedEventArgs e)
		{
			if (TbxPassword.Text == "Password")
				TbxPassword.Text = "";
		}

		private void TbxLogin_LostFocus(object sender, RoutedEventArgs e)
		{
			if (TbxLogin.Text == "")
				TbxLogin.Text = "Login";
		}

		private void TbxPassword_LostFocus(object sender, RoutedEventArgs e)
		{
			if (TbxPassword.Text == "")
				TbxPassword.Text = "Password";
		}

		private void BtnOk_Click(object sender, RoutedEventArgs e)
		{
			if (ValidCredentials())
			{
				try
				{
					mw.FrmMainWindow.Navigate(new Uri("UI/MainWindowLoggedPage.xaml", UriKind.Relative));
				}
				catch (IOException exception)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine(exception.Message);
					Console.ResetColor();
				}
			}
			else
			{
				LblMessage.Content = "Wrong credentials.";
			}
		}

		private bool ValidCredentials()
		{
			return mw.facade.CheckLogin(TbxLogin.Text, TbxPassword.Text);
		}
	}
}
