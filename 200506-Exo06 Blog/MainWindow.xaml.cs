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
using _200506_Exo06_Blog.UI;

namespace _200506_Exo06_Blog
{
	/// <summary>
	/// Logique d'interaction pour MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		public void ShowAddUserDialog_CanExecute(object sender, CanExecuteRoutedEventArgs e){e.CanExecute = true;}

		public void ShowAddUserDialog_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			// MessageBox.Show("Youpi!");
			AddUserWindow.GetInstance().ShowDialog();
			
		}
	}
}
