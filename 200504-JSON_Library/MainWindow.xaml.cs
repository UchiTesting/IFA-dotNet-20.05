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
using System.IO;

namespace _200504_JSON_Library
{
	/// <summary>
	/// Logique d'interaction pour MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private readonly string _path;
		public List<Book> Books { get; set; }
		public MainWindow()
		{
			InitializeComponent();
			_path = $"{Directory.GetCurrentDirectory()}\\testFileName.json";
			if (File.Exists(_path))
				testJSONLoad();
			else
				testJSONSave();

			DgBooks.ItemsSource = Books;
		}

		private void testJSONSave()
		{
			LibrarySerializer librarySerializer = new LibrarySerializer(_path);
			librarySerializer.Books.Add(new Book("Book 1", "Author 1", 1));
			librarySerializer.Books.Add(new Book("Book 2", "Author 2", 2));
			librarySerializer.Books.Add(new Book("Book 3", "Author 3", 3));

			librarySerializer.Save();
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
		}

		private void testJSONLoad()
		{
			LibrarySerializer librarySerializer = new LibrarySerializer(_path);
			librarySerializer.Load();

			Books = librarySerializer.Books;
		}

		private void SaveJSON_Executed(object sender, ExecutedRoutedEventArgs e)
		{
		}
	}
}
