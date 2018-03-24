﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Xceed.Wpf.Toolkit;

namespace VidCoder.View
{
	/// <summary>
	/// Interaction logic for PicturePanel.xaml
	/// </summary>
	public partial class SizingPanel : UserControl
	{
		public SizingPanel()
		{
			this.InitializeComponent();

			this.colorPicker.StandardColors = new ObservableCollection<ColorItem>
			{
				new ColorItem(Colors.Black, "Black"),
				new ColorItem(Colors.White, "White")
			};
		}
	}
}