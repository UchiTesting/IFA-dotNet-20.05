using System.Windows;
using System.Windows.Input;

namespace _200506_Exo06_Blog.UI
{
   public partial class AddUserWindow : Window
   {
      private static AddUserWindow _instance;
      private  AddUserWindow()
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

      public void Cancel_CanExecute(object sender, CanExecuteRoutedEventArgs e) { e.CanExecute = true; }

      public void Cancel_Executed(object sender, ExecutedRoutedEventArgs e)
      {
         //this.Close();
         this.Visibility = Visibility.Hidden;
      }
   }
}