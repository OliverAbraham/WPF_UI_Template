using System.Collections.Generic;
using System.Windows.Controls;

namespace WPF_UI_Template.Pages
{
	public partial class NavigationGroup4 : Page
	{
		public List<GridMiddleDataGridItem> Items { get; private set; }
		private MainWindow _mainWindow;

		public NavigationGroup4(MainWindow mainWindow)
		{
			_mainWindow = mainWindow;
			InitializeComponent();
			DataContext = this;

			Items = new List<GridMiddleDataGridItem>();
			Items.Add(new GridMiddleDataGridItem(1, "/Resources/DocumentGroup.png"    , "4 LONGER TEXT 1234", "shorter Text"));
			Items.Add(new GridMiddleDataGridItem(2, "/Resources/FolderOpened.png"     , "4 LONGER TEXT 1234", "shorter Text"));
			Items.Add(new GridMiddleDataGridItem(3, "/Resources/StatusInformation.png", "4 LONGER TEXT 1234", "shorter Text"));

			//RightContentFrame.Content = new Group1_Page1(_mainWindow, this);
		}
	}
}
