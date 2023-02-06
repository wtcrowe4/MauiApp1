namespace MauiApp1;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count += 3;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

	private void PopUpClick(object sender, EventArgs e)
	{
		DisplayAlert("Whats up", "lorem ipsum", "Back");
	}

	private async void InternetClick(object sender, EventArgs e)
	{
		var hasInternet = Connectivity.NetworkAccess == NetworkAccess.Internet;

		await DisplayAlert("Internet?", $"{hasInternet}", "OK");
	}
}

