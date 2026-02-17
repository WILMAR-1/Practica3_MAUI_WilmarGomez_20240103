namespace Practica3_MAUI_WilmarGomez_20240103;

public partial class DashboardPage : ContentPage
{
	public DashboardPage()
	{
		InitializeComponent();
	}

    private async void OnActualizarClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Actualizado", "Los datos han sido actualizados", "OK");
    }
}
