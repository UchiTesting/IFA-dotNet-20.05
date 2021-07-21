using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _200525_Exo08_Library.Helpers
{
	public class ApplicationCommands
	{
		public static RoutedUICommand TryLogin = new RoutedUICommand("Try Login","TryLogin",typeof(ApplicationCommands));
	}
}
