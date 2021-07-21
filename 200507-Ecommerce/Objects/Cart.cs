using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace _200507_Exo07_Ecommerce.Objects
{
	public class Cart : INotifyPropertyChanged
	{
		public Cart() { }

		private int _id;
		private Dictionary<int, int> orderedProducts;


		public int Id { get { return _id; } set { if (_id != value) _id = value; NotifyPropertyChanged("Id"); } }
		// Dictionary for ProductID and respective quantity
		public Dictionary<int, int> OrderedProducts { get { return orderedProducts;} set { if (orderedProducts != value) orderedProducts = value; NotifyPropertyChanged("OrderedProducts");} }

		public event PropertyChangedEventHandler PropertyChanged;

		public void NotifyPropertyChanged(string propName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
		}

		public void GetTotalAmount()
		{
			// TODO Computes the total amount for the products in the list
			// Calls GetTotalPriceForSpecificProduct() on each line of the dictionary.
		}

		public void GetTotalPriceForSpecificProduct()
		{
			// TODO Compute the total amount for one product in the cart.
		}

		public int GetNumberOfArticles()
		{
			// TODO return number of different articles
			throw new NotImplementedException($"You muppet implement me in {this.GetType().FullName}.");
		}
	}
}
