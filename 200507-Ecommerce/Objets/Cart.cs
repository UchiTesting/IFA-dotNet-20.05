﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _200507_Ecommerce.Objets
{
	class Cart
	{
		public int Id { get; set; }
		public Dictionary<Product,int> OrderedProducts { get; set; }

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
