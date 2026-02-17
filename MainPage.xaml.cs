namespace Practica3_MAUI_WilmarGomez_20240103;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private async void OnFormularioClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FormularioPage());
    }

    private async void OnDashboardClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DashboardPage());
    }

    private async void OnGaleriaClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GaleriaPage());
    }

    private async void OnCreativeClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CreativePage());
    }
}
