namespace Practica3_MAUI_WilmarGomez_20240103;

public partial class CreativePage : ContentPage
{
	public CreativePage()
	{
		InitializeComponent();
	}

    private async void OnContactarClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Contacto", "Correo enviado a Wilmar Gomez (simulación).", "OK");
    }
}
