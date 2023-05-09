namespace Eksamensprojekt;

public partial class LokalePage : ContentPage
{
	public LokalePage()
	{
		InitializeComponent();
    }

    private void OnH201(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SecondPage());
    }
    private void OnH202(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SecondPage());
    }
    private void OnH203(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SecondPage());
    }
    private void OnH204(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SecondPage());
    }
    private void OnH208(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SecondPage());
    }
    private void OnH223(object sender, EventArgs e)
    {
        //Navigation.PushAsync(new AdministrativSide());
    }
    private void OnH227(object sender, EventArgs e)
    {
        //Navigation.PushAsync(new AdministrativSide());
    }
    private void OnH229(object sender, EventArgs e)
    {
        //Navigation.PushAsync(new AdministrativSide());
    }
}