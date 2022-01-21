namespace WPF_UI_Template
{
	public  class GridMiddleDataGridItem
	{
		public int    ID        { get; set; }
		public string ImageName { get; set; }
		public string TextLine1 { get; set; }
		public string TextLine2 { get; set; }

		public GridMiddleDataGridItem(int id, string imageName, string textLine1, string textLine2)
		{
			ID        = id;
			ImageName = imageName;	
			TextLine1 = textLine1;
			TextLine2 = textLine2;
		}
	}
}