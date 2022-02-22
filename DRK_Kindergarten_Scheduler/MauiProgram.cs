using Microsoft.AspNetCore.Components.WebView.Maui;
using DRK_Kindergarten_Scheduler.Data;
using MudBlazor.Services;


namespace DRK_Kindergarten_Scheduler;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.RegisterBlazorMauiWebView()
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddBlazorWebView();
		builder.Services.AddSingleton<WeatherForecastService>();

		// For MudBlazor
		builder.Services.AddMudServices();

		return builder.Build();
	}
}
