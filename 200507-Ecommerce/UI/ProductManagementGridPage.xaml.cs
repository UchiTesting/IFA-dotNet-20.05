using System;
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
using _200507_Exo07_Ecommerce.Objects;
namespace _200507_Exo07_Ecommerce.UI
{
	/// <summary>
	/// Interaction logic for ProductManagementGridPage.xaml
	/// </summary>
	public partial class ProductManagementGridPage : Page
	{
		MainWindow mw;
		//private List<Product> _products;

		public ProductManagementGridPage()
		{
			mw = ((MainWindow)Application.Current.MainWindow);
			//_products = mw.facade.Products;
			InitializeComponent();
			DgArticleList.ItemsSource = mw.facade.Products;
			UpdateProductList();

		}

		private void UpdateProductList()
		{
			DgArticleList.Items.Refresh();
		}

		private void BtnArchiveProduct_Click(object sender, RoutedEventArgs e)
		{
			Product selectedProduct = (Product)DgArticleList.SelectedItem;

			mw.facade.ToggleProductArchivedStatus(selectedProduct);

			string itemInfo = $"{selectedProduct.Id} {selectedProduct.Name} {Environment.NewLine} " +
				$"{selectedProduct.Description} {Environment.NewLine}" +
				$"{selectedProduct.Price} {selectedProduct.IsArchived}";
			Console.WriteLine("Clicked Toggle Archive\n" + itemInfo);
		}

		private void BtnEditProduct_Click(object sender, RoutedEventArgs e)
		{
			Product selectedProduct = (Product)DgArticleList.SelectedItem;

			mw.FrmMainWindow.Navigate(new NewProductPage(selectedProduct.Id));

			string itemInfo = $"{selectedProduct.Id} {selectedProduct.Name} {Environment.NewLine} " +
				$"{selectedProduct.Description} {Environment.NewLine}" +
				$"{selectedProduct.Price} {selectedProduct.IsArchived}";
			Console.WriteLine("Clicked Edit" + itemInfo);

		}
	}
}
