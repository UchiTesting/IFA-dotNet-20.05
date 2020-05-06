using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _200506_Exo06_Blog.Commands
{
	public static class MainWindowCommands
	{
		public static readonly RoutedUICommand ShowAddUserDialog = new RoutedUICommand("Add User...","ShowAddUserDialog",typeof(MainWindowCommands));
		
		public static readonly RoutedUICommand ShowEditUserDialog = new RoutedUICommand("Add User...","ShowAddUserDialog",typeof(MainWindowCommands));

	}
}
