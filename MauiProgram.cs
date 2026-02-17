using Microsoft.Extensions.Logging;

namespace Practica3_MAUI_WilmarGomez_20240103;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("ka1.ttf", "KarmaticArcade");
				fonts.AddFont("Minecraft.ttf", "Minecraft");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
