using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _200506_Exo06_Blog.Commands
{
	public static class AddUserWindowCommands
	{
		public static readonly RoutedUICommand Cancel = new RoutedUICommand("Cancel","Cancel",typeof(AddUserWindowCommands));
	}
}
