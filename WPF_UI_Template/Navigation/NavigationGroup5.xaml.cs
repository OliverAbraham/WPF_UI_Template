using System.Collections.Generic;
using System.Windows.Controls;

namespace WPF_UI_Template.Pages
{
	public partial class NavigationGroup5 : Page
	{
		public List<GridMiddleDataGridItem> Items { get; private set; }
		private MainWindow _mainWindow;

		public NavigationGroup5(MainWindow mainWindow)
		{
			_mainWindow = mainWindow;
			InitializeComponent();
			DataContext = this;

			Items = new List<GridMiddleDataGridItem>();
			Items.Add(new GridMiddleDataGridItem(1, "/Resources/DocumentGroup.png"    , "5 PAGE 1", "shorter Text"));
			Items.Add(new GridMiddleDataGridItem(2, "/Resources/FolderOpened.png"     , "5 PAGE 2", "shorter Text"));
			Items.Add(new GridMiddleDataGridItem(3, "/Resources/DatabaseReport.png"   , "5 PAGE 3", "shorter Text"));

			RightContentFrame.Content = new Group5_Page1(_mainWindow);
		}

		private void SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			RightContentFrame.Content = (e.AddedItems[0] as GridMiddleDataGridItem).ID switch
			{
				1 => new Group5_Page1(_mainWindow),
				2 => new Group5_Page2(_mainWindow),
				3 => new Group5_Page3(_mainWindow),
			};
		}
	}
}
