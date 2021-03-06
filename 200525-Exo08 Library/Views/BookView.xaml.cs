﻿using System;
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

namespace _200525_Exo08_Library.Views
{
	/// <summary>
	/// Interaction logic for BookView.xaml
	/// </summary>
	public partial class BookView : Page
	{
		AppDBContext db;

		public BookView()
		{
			InitializeComponent();
			db = new AppDBContext();

			LvBooks.ItemsSource = db.Books.Local;
			// Local being a cache keeping the content of the last request.
			// 
			db.Books.Load();

			CbxAuthor.ItemsSource = db.Authors.Local;
			db.Authors.Load();
		}


		private void BtnAdd_Click(object sender, RoutedEventArgs e)
		{
			Book nb = new Book();

			nb.Title = TbxTitle.Text;
			nb.Summary = TbxSummary.Text;
			nb.ReleaseDate = (DateTime)DpkDate.SelectedDate;
			nb.OwnAuthor = (Author)CbxAuthor.SelectedItem;

			db.Books.Add(nb);
			db.SaveChanges();
		}

		private void BtnEdit_Click(object sender, RoutedEventArgs e)
		{
			Book nb = LvBooks.SelectedItem as Book;

			if (nb is null) return;

			nb.Title = TbxTitle.Text;
			nb.Summary = TbxSummary.Text;
			nb.ReleaseDate = (DateTime)DpkDate.SelectedDate;
			nb.OwnAuthor = (Author)CbxAuthor.SelectedItem;

			db.SaveChanges();
		}

		private void BtnDelete_Click(object sender, RoutedEventArgs e)
		{
			Book nb = LvBooks.SelectedItem as Book;

			if (nb is null) return;

			db.Books.Remove(nb);
			db.SaveChanges();
		}

		private void LvBooks_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			LvBooks.ItemsSource = db.Books.Local;
			db.Books.ToList();
			Book nb = LvBooks.SelectedItem as Book;

			if (nb is null) return;

			TbxTitle.Text = nb.Title;
			TbxSummary.Text = nb.Summary;
			DpkDate.SelectedDate = nb.ReleaseDate;
			CbxAuthor.SelectedItem = nb.OwnAuthor;
		}
	}
}
