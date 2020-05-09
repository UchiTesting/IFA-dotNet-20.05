using System.Windows;
using System.Windows.Input;

namespace _200506_Exo06_Blog.UI
{
	public partial class AddUserWindow : Window
	{
		private static AddUserWindow _instance;
		private AddUserWindow()
		{
			InitializeComponent();
			this.Owner = App.Current.MainWindow;
		}

		public static AddUserWindow GetInstance()
		{
			if (_instance is null)
			{
				_instance = new AddUserWindow();
			}

			return _instance;
		}

		public void OK_CanExecute(object sender, CanExecuteRoutedEventArgs e) { e.CanExecute = true; }

		public void OK_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			
			
			((MainWindow)App.Current.MainWindow).Users.Add(new _200506_Exo06_Blog.Objects.User(){ Login=TbLogin.Text, Password=TbPassword.Text,Priviledge=((_200506_Exo06_Blog.Enums.UserRightsEnum)CbPriviledge.SelectedIndex)});

			this.Visibility = Visibility.Hidden;
			CleanInputs();
		}
		public void Cancel_CanExecute(object sender, CanExecuteRoutedEventArgs e) { e.CanExecute = true; }

		public void Cancel_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			this.Visibility = Visibility.Hidden;
			CleanInputs();
		}

		private void CleanInputs()
		{
			TbLogin.Clear();
			TbPassword.Clear();
			CbPriviledge.SelectedIndex = 0;
		}
	}
}