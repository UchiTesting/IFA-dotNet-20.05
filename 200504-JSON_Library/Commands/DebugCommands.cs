using System.Windows.Input;

namespace _200504_JSON_Library.Commands
{
	public static class DebugCommands
	{
		public static RoutedUICommand DisplayHeadCollection = new RoutedUICommand("Display head of the collection","DispHead",typeof(DebugCommands));
		//public static RoutedUICommand EnableDataGridEditing = new RoutedUICommand("Enable Editing","EnableDataGridEditing",typeof(DebugCommands));
		//public static  RoutedUICommand LoadJSON = new RoutedUICommand("Load JSON File...", "LoadJSON",typeof(DebugCommands));
		//public static RoutedUICommand Quit = new RoutedUICommand("Quit", "Quit",typeof(DebugCommands));
		//public static  RoutedUICommand SaveJSON = new RoutedUICommand("Save JSON File...", "SaveJSON",typeof(DebugCommands));
	}
}