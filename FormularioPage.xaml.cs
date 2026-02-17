namespace Practica3_MAUI_WilmarGomez_20240103;

public partial class FormularioPage : ContentPage
{
	public FormularioPage()
	{
		InitializeComponent();
	}

    private void OnRegistrarClicked(object sender, EventArgs e)
    {
        // Validar que todos los campos estén llenos
        if (string.IsNullOrWhiteSpace(entryNombre.Text))
        {
            labelResultado.Text = "   Por favor ingresa tu nombre";
            labelResultado.TextColor = Colors.Red;
            return;
        }

        if (string.IsNullOrWhiteSpace(entryEmail.Text))
        {
            labelResultado.Text = "   Por favor ingresa tu email";
            labelResultado.TextColor = Colors.Red;
            return;
        }

        if (!switchTerminos.IsToggled)
        {
            labelResultado.Text = "   Debes aceptar los términos";
            labelResultado.TextColor = Colors.Red;
            return;
        }

        // Si todo está bien
        labelResultado.Text = $"      ¡Bienvenido {entryNombre.Text}!";
        labelResultado.TextColor = Colors.Green;
    }
}
