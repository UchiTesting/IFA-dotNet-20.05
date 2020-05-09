using System.Windows.Input;

namespace _200504_JSON_Library.Commands
{
	public static class ApplicationCommands
	{
		public static RoutedUICommand ClearDataGrid = new RoutedUICommand("Clear Data","ClearDataGrid",typeof(ApplicationCommands));
		public static RoutedUICommand EnableDataGridEditing = new RoutedUICommand("Enable Editing","EnableDataGridEditing",typeof(ApplicationCommands));
		public static  RoutedUICommand LoadJSON = new RoutedUICommand("Load JSON File...", "LoadJSON",typeof(ApplicationCommands));
		public static RoutedUICommand Quit = new RoutedUICommand("Quit", "Quit",typeof(ApplicationCommands));
		public static  RoutedUICommand SaveJSON = new RoutedUICommand("Save JSON File...", "SaveJSON",typeof(ApplicationCommands));
	}
}