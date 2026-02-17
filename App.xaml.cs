namespace Practica3_MAUI_WilmarGomez_20240103;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new MainPage());
	}
}