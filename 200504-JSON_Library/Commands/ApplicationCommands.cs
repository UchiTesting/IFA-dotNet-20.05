using System.Windows.Input;

namespace _200504_JSON_Library.Commands
{
	public class ApplicationCommands
	{
		public static  RoutedUICommand LoadJSON = new RoutedUICommand("Load JSON File...", "LoadJSON",typeof(ApplicationCommands));
		public static  RoutedUICommand SaveJSON = new RoutedUICommand("Save JSON File...", "SaveJSON",typeof(ApplicationCommands));
	}
}