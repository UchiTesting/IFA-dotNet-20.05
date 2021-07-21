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
using System.Windows.Navigation;
using System.Windows.Shapes;
using _200507_Ecommerce;

namespace _200507_Exo07_Ecommerce.UI
{
	/// <summary>
	/// Logique d'interaction pour MainWindowLoggedPage.xaml
	/// </summary>
	public partial class MainWindowLoggedPage : Page
	{
		private MainWindow mw;
		public MainWindowLoggedPage()
		{
			mw = ((MainWindow)App.Current.MainWindow);
			InitializeComponent();
			DisplayAdminTabWhenRelevant();

		}

		private void DisplayAdminTabWhenRelevant()
		{
			if (mw.facade.LoggedUser.IsAdmin)
				TiAdmin.Visibility = Visibility.Visible;
			else
				TiAdmin.Visibility = Visibility.Collapsed;
		}
	}
}
