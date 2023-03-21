namespace MauiBottomSheetSample;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		var page = new MyBottomSheet();

		page.ShowHandle = true;

		page.Show(Window);
	}
}

