using System;

namespace _200507_Exo07_Ecommerce.Objects
{
	public class MonetaryAmount
	{
		private decimal _amount; // decimal is the type recommended for money by MSDN
		public decimal Amount
		{
			get => Math.Round(_amount, 2);
			set => _amount = Math.Round(value, 2);
		}
		public string CurrencySymbol { get; set; }
		public string MonetaryShortTerm { get; set; }

		public MonetaryAmount(decimal amount, string currencySymbol = "€", string mst="EUR")
		{
			Amount = amount;
			CurrencySymbol = currencySymbol;
			MonetaryShortTerm = mst;
		}

		public MonetaryAmount() { }

		// Add some code to make this type simple to work with

		public override string ToString()
		{
			return $"{Amount,2}";
		}
	}
}
