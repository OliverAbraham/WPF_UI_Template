using WPF_UI_Template.Pages;
using WPF_UI_Template.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WPF_UI_Template
{
	public partial class MainWindow : Window, INotifyPropertyChanged
	{
		public MainWindow()
		{
			InitializeComponent();
			SelectPage1(null, null);
			DataContext = this;
		}

		private void SelectPage1(object sender, MouseButtonEventArgs e) { MiddleNagivationFrame.Content = new NavigationGroup1(this); }
		private void SelectPage2(object sender, MouseButtonEventArgs e) { MiddleNagivationFrame.Content = new NavigationGroup2(this); }
		private void SelectPage3(object sender, MouseButtonEventArgs e) { MiddleNagivationFrame.Content = new NavigationGroup3(this); }
		private void SelectPage4(object sender, MouseButtonEventArgs e) { MiddleNagivationFrame.Content = new NavigationGroup4(this); }
		private void SelectPage5(object sender, MouseButtonEventArgs e) { MiddleNagivationFrame.Content = new NavigationGroup5(this); }


		#region ------------- INotifyPropertyChanged ---------------------------

		// add "INotifyPropertyChanged" to your class
		// add "using System.ComponentModel";
		// add "using System";

		[NonSerialized]
		private PropertyChangedEventHandler _PropertyChanged;
		private Brush foregroundColor;
		private Brush backgroundColor;

		public event PropertyChangedEventHandler PropertyChanged
		{
			add
			{
				_PropertyChanged += value;
			}
			remove
			{
				_PropertyChanged -= value;
			}
		}

		public void NotifyPropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler Handler = _PropertyChanged; // avoid race condition
			if (Handler != null)
				Handler(this, new PropertyChangedEventArgs(propertyName));
		}

		#endregion
	}
}
