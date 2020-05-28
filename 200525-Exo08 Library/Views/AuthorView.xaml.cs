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
using _200525_Exo08_Library.Models;
using _200525_Exo08_Library.Helpers;
using System.Data.Entity;
using System.Data.SqlClient;

namespace _200525_Exo08_Library.Views
{
	/// <summary>
	/// Interaction logic for AuthorView.xaml
	/// </summary>
	public partial class AuthorView : Page
	{
		AppDBContext db;

		public AuthorView()
		{
			InitializeComponent();
			db = new AppDBContext();

			LvAuthors.ItemsSource = db.Authors.Local;
			db.Authors.Load();
		}

		private void BtnAdd_Click(object sender, RoutedEventArgs e)
		{
			Author na = new Author();

			na.Name = TbxAuthorName.Text;

			db.Authors.Add(na);
			db.SaveChanges();
		}

		private void BtnEdit_Click(object sender, RoutedEventArgs e)
		{
			Author na = LvAuthors.SelectedItem as Author;

			if (na is null) return;

			na.Name = TbxAuthorName.Text;

			db.SaveChanges();
		}

		private void BtnDelete_Click(object sender, RoutedEventArgs e)
		{
			Author na = LvAuthors.SelectedItem as Author;

			if (na is null) return;

			

			if (na.WrittenBooks.Count == 0)
			{
				db.Authors.Remove(na);
				db.SaveChanges();
			}
			else
			{
				MessageBox.Show($"{na.Name} still has a book !", "Check it out!");
			}
		}

		private void LvAuthors_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			Author na = LvAuthors.SelectedItem as Author;

			if (na is null) return;

			TbxAuthorName.Text = na.Name;
		}
	}
}
