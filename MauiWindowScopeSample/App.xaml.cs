using System.Reflection;

namespace MauiWindowScopeSample;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        Task.Run(async () =>
        {
            while (true)
            {
                GC.Collect(int.MaxValue, GCCollectionMode.Forced, true);
                GC.WaitForPendingFinalizers();
                await Task.Delay(2000);
            }
        });
	}

    protected override Window CreateWindow(IActivationState activationState)
    {
        //typeof(MessagingCenter).GetMethod("ClearSubscribers", BindingFlags.NonPublic | BindingFlags.Static).Invoke(null, null);
        return activationState.Context.Services.GetRequiredService<MainWindow>();
    }
}

