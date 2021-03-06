using System;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPF_UI_Template.Pages
{
	public partial class Group1_Page1 : Page, INotifyPropertyChanged
	{
		private MainWindow _mainWindow;
		private NavigationGroup1 _navigationPage;

		public Group1_Page1(MainWindow mainWindow, NavigationGroup1 navigationPage)
		{
			_mainWindow = mainWindow;
			_navigationPage = navigationPage;
			InitializeComponent();
			DataContext = this;
		}

		#region ------------- INotifyPropertyChanged ---------------------------
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
