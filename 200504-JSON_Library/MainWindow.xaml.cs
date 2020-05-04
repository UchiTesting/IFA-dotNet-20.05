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
using Microsoft.Win32;

namespace _200504_JSON_Library
{
	/// <summary>
	/// Logique d'interaction pour MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		JSONFile<Library> jSONFile;
		Library lib;

		public MainWindow()
		{
			InitializeComponent();
			lib = new Library();

			lib.AddBook("Un livre trop cool","Jimmy Booker",1);
			lib.AddBook("A book you wanna read","Patty Writter",2);
			lib.AddBook("SOmthing interesting","Garry Somthing",3);
		}

		private void LoadJSON_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = true;
		}
		private void SaveJSON_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = true;
		}
		private void LoadJSON_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			jSONFile = new JSONFile<Library>();
			jSONFile.Load();

		}
		private void SaveJSON_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			if (jSONFile is null)
			{
				MessageBox.Show("Nothing to save.","Object not defined");
			}
			else
			{
				jSONFile.Save();
			}

		}
	}
}
