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

namespace _200525_Exo08_Library
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		AppDBContext db;

		public MainWindow()
		{
			InitializeComponent();
			db = new AppDBContext();

			LvBooks.ItemsSource = db.Books.Local;
			// Local being a cache keeping the content of the last request.
			// 
			db.Books.Load();
		}

		private void BtnAdd_Click(object sender, RoutedEventArgs e)
		{
			Book nb = new Book();
			nb.Title = TbxTitle.Text;
			nb.Summary = TbxSummary.Text;
			nb.ReleaseDate = DateTime.Now;
			nb.OwnAuthor.Name = TbxAuthor.Text;

			db.Books.Add(nb);
			db.SaveChanges();
		}

		private void BtnDelete_Click(object sender, RoutedEventArgs e)
		{
			Book nb = LvBooks.SelectedItem as Book;

			if (nb is null) return;

			db.Books.Remove(nb);
			db.SaveChanges();
		}

		private void BtnEdit_Click(object sender, RoutedEventArgs e)
		{
			Book nb = LvBooks.SelectedItem as Book;

			if (nb is null) return;

			nb.Title = TbxTitle.Text;
			nb.Summary = TbxSummary.Text;
			nb.OwnAuthor.Name = TbxAuthor.Text;

			//db.Books.Remove(nb);
			db.SaveChanges();
		}

		private void LvBooks_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			Book nb = LvBooks.SelectedItem as Book;

			if (nb is null) return;

			TbxTitle.Text = nb.Title;
			TbxSummary.Text = nb.Summary;
			TbxDate.Text = nb.ReleaseDate.ToString();
			TbxAuthor.Text = nb.OwnAuthor.Name;
		}
	}
}
