using Microsoft.Extensions.Logging;
using Microsoft.Maui.LifecycleEvents;

namespace MauiWindowScopeSample;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			})
			.ConfigureLifecycleEvents(events =>
			{
#if ANDROID
				events.AddAndroid(android => android
					.OnActivityResult((a, b, c, d) => LogEvent(nameof(AndroidLifecycle.OnActivityResult), b.ToString()))
					.OnBackPressed((a) => LogEvent(nameof(AndroidLifecycle.OnBackPressed)) && false)
					.OnConfigurationChanged((a, b) => LogEvent(nameof(AndroidLifecycle.OnConfigurationChanged)))
					.OnCreate((a, b) => LogEvent(nameof(AndroidLifecycle.OnCreate)))
					.OnDestroy((a) => LogEvent(nameof(AndroidLifecycle.OnDestroy)))
					.OnNewIntent((a, b) => LogEvent(nameof(AndroidLifecycle.OnNewIntent)))
					.OnPause((a) => LogEvent(nameof(AndroidLifecycle.OnPause)))
					.OnPostCreate((a, b) => LogEvent(nameof(AndroidLifecycle.OnPostCreate)))
					.OnPostResume((a) => LogEvent(nameof(AndroidLifecycle.OnPostResume)))
					.OnRequestPermissionsResult((a, b, c, d) => LogEvent(nameof(AndroidLifecycle.OnRequestPermissionsResult)))
					.OnRestart((a) => LogEvent(nameof(AndroidLifecycle.OnRestart)))
					.OnRestoreInstanceState((a, b) => LogEvent(nameof(AndroidLifecycle.OnRestoreInstanceState)))
					.OnResume((a) => LogEvent(nameof(AndroidLifecycle.OnResume)))
					.OnSaveInstanceState((a, b) => LogEvent(nameof(AndroidLifecycle.OnSaveInstanceState)))
					.OnStart((a) => LogEvent(nameof(AndroidLifecycle.OnStart)))
					.OnStop((a) => LogEvent(nameof(AndroidLifecycle.OnStop))));
#endif
			})
			.Services
				.AddScoped<MainWindow>()
				.AddScoped<ScopedService>();

		static bool LogEvent(string eventName, string type = null)
		{
			Console.WriteLine($"Lifecycle event: {eventName}{(type == null ? "" : $" ({type})")}");
			return true;
		}

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

