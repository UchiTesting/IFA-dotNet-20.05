﻿using System;
using System.Collections.Generic;
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
using _200507_Ecommerce.Enums;

namespace _200507_Exo07_Ecommerce
{
	/// <summary>
	/// Logique d'interaction pour MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public  EShopFacade facade;
		public MainWindow()
		{
			InitializeComponent();
			ApplicationContext db = new ApplicationContext();
			facade = new EShopFacade(db);
		}
	}
}
