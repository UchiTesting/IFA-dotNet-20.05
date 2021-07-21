using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _200507_Ecommerce.Objets
{
	public class MonetaryAmount
	{
		private decimal _amount; // decimal is the type recommended for money by MSDN
		public decimal Amount { get {return Math.Round(_amount,2); } set {_amount = Math.Round(value,2); } }
		public string CurrencySymbol { get; set; }
		public string MonetaryShortTerm { get; set; }

		public MonetaryAmount(decimal amount, string currencySymbol = "€")
		{
			Amount = amount;
			CurrencySymbol = currencySymbol;
		}

		// Add some code to make this type simple to work with
	}
}
