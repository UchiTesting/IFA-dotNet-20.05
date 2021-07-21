using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using _200507_Exo07_Ecommerce.Extensions;
using System.Windows;
using System.Data.SqlClient;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows.Controls;

namespace _200507_Exo07_Ecommerce.Objects
{
	public class EShopFacade
	{
		private readonly ApplicationContext _db;
		public const bool DEBUG = true;

		public ObservableCollection<User> Users { get; set; }
		//public List<User> Users{ get; set; }
		public ObservableCollection<Product> Products { get; set; }
		public ObservableCollection<Cart> Carts { get; set; }
		public User LoggedUser { get; set; }


		public EShopFacade(ApplicationContext db)
		{
			_db = db;
			try
			{
				RefreshUsers();
				RefreshProducts();
				RefreshCarts();
			}
			catch (SqlException e)
			{
				MessageBox.Show($"Cannot connect to database.{Environment.NewLine}{e.Message}");
			}

			if (DEBUG) Debug_ShowUserListCLI();

			Products.CollectionChanged += OnProductChange;
		}

		private void RefreshCarts()
		{
			Carts = _db.Carts.ToObservableCollection() ?? new ObservableCollection<Cart>();
		}

		private void RefreshProducts()
		{
			Products = _db.Products.ToObservableCollection() ?? new ObservableCollection<Product>();
		}

		private void RefreshUsers()
		{
			Users = _db.Users.ToObservableCollection() ?? new ObservableCollection<User>();
		}

		/*=================================================================================================================*/

		public void CreateAdmin() // Todo : Update this with admin creation only if User table is empty
		{
			//ApplicationContext _db = new ApplicationContext();
			User u = new User() { IsAdmin = true, Login = "admin", Password = "admin" };
			Users.Add(u);
			_db.Users.AddOrUpdate(u);
			_db.SaveChanges();

			if (DEBUG) MessageBox.Show("Admin Created");
		}

		public void CreateUser(string login, string pass, bool isAdmin)
		{
			User u = new User { IsAdmin = isAdmin, Login = login, Password = pass };
			_db.Users.AddOrUpdate(u);
			_db.SaveChanges();
		}

		public bool CheckLogin(string login, string password)
		{
			try
			{
				LoggedUser = (from user in _db.Users where user.Login == login && user.Password == password select user)
					.First();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		/*=================================================================================================================*/

		public void InsertProduct(string name, string desc, MonetaryAmount amount)
		{
			Product p = new Product { Name = name, Description = desc, Price = amount };
			_db.Products.Add(p);
			_db.SaveChanges();
			Products.Add(p);
		}

		
		public void UpdateProduct(Product product)
		{
			var result = _db.Products.SingleOrDefault(p => p.Id == product.Id);
			result.Name = product.Name;
			result.Description = product.Description;
			result.Price = product.Price;

			_db.SaveChanges();
			RefreshProducts();
		}

		public void ToggleProductArchivedStatus(Product product)
		{
			//Product selectedProduct = (Product)
			var result = _db.Products.SingleOrDefault(p => p.Id == product.Id);
			if (result != null)
			{
				result.IsArchived = !result.IsArchived;
				

				_db.SaveChanges();
				RefreshProducts();

				OnProductChange(this,null);
			}
		}

		/*=================================================================================================================*/

		private void OnProductChange(object sender, NotifyCollectionChangedEventArgs e)
		{
			Console.WriteLine("Facade tells Product collection Changed.");
		}

		/*=================================================================================================================*/

		public void Debug_ShowUserListCLI()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			foreach (var dbUser in _db.Users)
			{
				Console.WriteLine($"l: {dbUser.Login} p: {dbUser.Password}");
			}
			Console.ResetColor();
		}
	}
}
