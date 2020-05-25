using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _200525_Exo08_Library.Models
{
	public class PropertyChangingClass : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		public void OnPropertyChanged(string propertyName) { 
			PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(propertyName));
			}
	}
}
