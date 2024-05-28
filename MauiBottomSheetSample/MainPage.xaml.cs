namespace MauiBottomSheetSample;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		var page = new MyBottomSheet();

		page.HasHandle = true;
		page.HandleColor = Colors.Red;

		await page.ShowAsync(Window);
	}
}

