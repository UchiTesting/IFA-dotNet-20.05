﻿using System;
using System.Collections.Generic;

namespace _200507_Exo07_Ecommerce.Objects
{
	public class Cart
	{
		public Cart() { }

		public int Id { get; set; }
		// Dictionary for ProductID and respective quantity
		public Dictionary<int, int> OrderedProducts { get; set; }

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
