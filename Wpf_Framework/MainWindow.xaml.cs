using System;
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

namespace Wpf_Framework
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private int _clickCount = 0;
		
		public MainWindow()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Counts clicks
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
		{
			_clickCount++;
			MessageBox.Show($"Button clicked {_clickCount} times");
		}
	}
}
