using System.ComponentModel;

namespace _200507_Exo07_Ecommerce.Objects
{
	public class Product : INotifyPropertyChanged

	{
		public Product() { }

		private int _id;
		private string _name;
		private string _description;
		private MonetaryAmount _price;
		private bool _isArchived;

		public int Id { get { return _id; } set { if (_id != value) _id = value; NotifyPropertyChanged("Id"); } }
		public string Name { get { return _name; } set { if (_name != value) _name = value; ; NotifyPropertyChanged("Name"); } }
		public string Description { get { return _description; } set { if (_description != value) _description = value; NotifyPropertyChanged("Description"); } }
		public MonetaryAmount Price { get { return _price; } set { if (_price != value) _price = value; NotifyPropertyChanged("Price"); } }
		public bool IsArchived { get { return _isArchived; } set { if (_isArchived != value) _isArchived = value; NotifyPropertyChanged("IsArchived"); } }

		public event PropertyChangedEventHandler PropertyChanged;

		public void NotifyPropertyChanged(string propName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
		}
	}
}
