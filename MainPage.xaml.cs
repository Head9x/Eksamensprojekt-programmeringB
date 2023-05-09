namespace Eksamensprojekt;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
    }

	private void OnKortClicked(object sender, EventArgs e)
	{
        Navigation.PushAsync(new KortPage());
    }
    private void OnLokaleClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new LokalePage());
    }
    private void OnBygningerClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SecondPage());
    }
}