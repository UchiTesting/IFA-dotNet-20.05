using System;
using System.Collections.Generic;
using System.Globalization;
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
	/// Interaction logic for NewProductPage.xaml
	/// </summary>
	public partial class NewProductPage : Page
	{
		MainWindow mw;
		private readonly int _passedId;

		public NewProductPage(int id = -1)
		{
			_passedId = id;

			mw = ((MainWindow)Application.Current.MainWindow);

			InitializeComponent();

			if (_passedId > 0)
				PopulateControls();

		}

		private void PopulateControls()
		{
			if (_passedId > -1)
			{
				Product p = (from product in mw.facade.Products
								 where product.Id == _passedId
								 select product).FirstOrDefault();

				if (p != null)
				{
					TbxName.Text = p.Name;
					TbxDescription.Text = p.Description;
					TbxPrice.Text = p.Price.Amount.ToString(CultureInfo.InvariantCulture);
				}
			}
		}

		private void BtnCancel_Click(object sender, RoutedEventArgs e)
		{
			CloseWindow();
		}

		private void CloseWindow()
		{
			mw.FrmMainWindow.Navigate(new Uri("UI/MainWindowLoggedPage.xaml", UriKind.Relative));
			// TODO Aiming at having the right tab. Does not work. See this later.
			mw.FrmMainWindow.MoveFocus(new TraversalRequest(FocusNavigationDirection.Last));
		}

		private void BtnOk_Click(object sender, RoutedEventArgs e)
		{
			if (_passedId > 0)
				UpdateProduct();
			else
				InsertProduct();
			CloseWindow();
		}

		private void UpdateProduct()
		{
			Product p = (from product in mw.facade.Products
				where product.Id == _passedId
				select product).FirstOrDefault();

			try
			{

				decimal amount = Convert.ToDecimal(TbxPrice.Text, System.Globalization.CultureInfo.InvariantCulture);
				MonetaryAmount ma = new MonetaryAmount { Amount = amount };

				p.Name = TbxName.Text;
				p.Description = TbxDescription.Text;
				p.Price = ma;

				mw.facade.UpdateProduct(p);
			}
			catch (Exception)
			{

				MessageBox.Show("Please input all the data needed in the proper format.", "Data check");
			}

		}

		private void InsertProduct()
		{

			try
			{
				decimal amount = Convert.ToDecimal(TbxPrice.Text, System.Globalization.CultureInfo.InvariantCulture);
				MonetaryAmount ma = new MonetaryAmount { Amount = amount };

				mw.facade.InsertProduct(TbxName.Text, TbxDescription.Text, ma);
			}
			catch (Exception)
			{

				MessageBox.Show("Please input all the data needed in the proper format.", "Data check");
			}
		}
	}
}
