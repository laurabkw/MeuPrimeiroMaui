using Microsoft.Extensions.Logging;

namespace MeuPrimeiroAppMaui;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("Roboto-Black.ttf", "Robotoblack");
				fonts.AddFont("Roboto-Bold.ttf", "Robotobold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
