using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
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
using _200504_JSON_Library.Extensions;
using _200507_Exo07_Ecommerce.Objects;

namespace _200507_Exo07_Ecommerce.UI
{
	/// <summary>
	/// Interaction logic for OrderDetailPage.xaml
	/// </summary>
	public partial class OrderDetailPage : Page
	{
		private ObservableCollection<Product> availableProducts = new ObservableCollection<Product>();
		private MainWindow mw;

		public OrderDetailPage()
		{
			mw = ((MainWindow) Application.Current.MainWindow);

			InitializeComponent();
			PopulateDataGrid();
			DgArticleList.ItemsSource = availableProducts;
			mw.facade.Products.CollectionChanged += OnProductChange;
		}

		private void PopulateDataGrid()
		{
			OnProductChange(this,null);
			availableProducts = (from p in mw.facade.Products where p.IsArchived == false select p).ToObservableCollection();
		}

		private void OnProductChange(object sender, NotifyCollectionChangedEventArgs e)
		{
			Console.WriteLine("OrderDetail says Received Event Products changed");
		}
	}
}
