using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

using _200504_JSON_Library.Extensions;

namespace _200504_JSON_Library
{
	/// <summary>
	/// Logique d'interaction pour MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private readonly string _path;
		public ObservableCollection<Book> Books { get; set; }
		public MainWindow()
		{
			Books = new ObservableCollection<Book>();
			InitializeComponent();
			_path = $"{Directory.GetCurrentDirectory()}\\Library.json";
			if (!File.Exists(_path))
				TestJsonSave();
			else
				TestJsonLoad();

			RefreshDataGrid();
		}

		private void RefreshDataGrid()
		{
			DgBooks.ItemsSource = Books;
		}

		private void TestJsonSave()
		{
			LibrarySerializer librarySerializer = new LibrarySerializer(_path) {Books = Books.ToList()};
			//for (int i = 1; i <= 20; i++)
			//{
			//	librarySerializer.Books.Add(new Book($"Book {i}", $"Author {i}", i));
			//}
			librarySerializer.Save();
		}
		private void TestJsonLoad()
		{
			LibrarySerializer librarySerializer = new LibrarySerializer(_path);
			librarySerializer.Load();

			Books = librarySerializer.Books.ToObservableCollection();

			//MessageBox.Show(librarySerializer.DisplayBooksAsString());
		}
		private void LoadJSON_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = true;
		}
		private void SaveJSON_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = true;
		}
		private void Quit_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = true;
		}
		private void LoadJSON_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			TestJsonLoad();
			RefreshDataGrid(); // Shouldn't it be automatic upon any change in the DataGrid?

		}
		private void SaveJSON_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			TestJsonSave();

		}
		private void Quit_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			App.Current.Shutdown();
		}
		private void ClearData_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			Books.Clear();

		}

		private void ClearData_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = true;
		}
		private void EnableEditing_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = true;
		}
		private void EnableEditing_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			BtnEnableEditing.Content = DgBooks.IsReadOnly ? "Disable Editing" : "Enable Editing";

			try
			{
				DgBooks.IsReadOnly = !DgBooks.IsReadOnly;
			}
			catch (Exception exception)
			{
				Console.Write(exception.Message);
			}
		}

		private void DisplayHeadCollection_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = true;
		}

		private void DisplayHeadCollection_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			StringBuilder sb = new StringBuilder();
			Books.ForEach(b => sb.AppendLine(b.ToString()));
			Console.WriteLine($"DEBUG {Environment.NewLine}: {sb.ToString()}");
			MessageBox.Show(sb.ToString(), "Debug");
		}
	}
}
