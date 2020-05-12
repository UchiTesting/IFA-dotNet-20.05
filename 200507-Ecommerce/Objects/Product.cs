namespace _200507_Exo07_Ecommerce.Objects
{
	public class Product
	{
		public Product() { }

		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public MonetaryAmount Price { get; set; }
		public bool IsArchived { get; set; }
	}
}
