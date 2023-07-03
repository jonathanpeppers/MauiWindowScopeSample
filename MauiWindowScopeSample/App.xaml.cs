using System.Reflection;

namespace MauiWindowScopeSample;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
	}

    protected override Window CreateWindow(IActivationState activationState)
    {
        //typeof(MessagingCenter).GetMethod("ClearSubscribers", BindingFlags.NonPublic | BindingFlags.Static).Invoke(null, null);
        GC.Collect(int.MaxValue, GCCollectionMode.Forced, true);
        GC.WaitForPendingFinalizers();
        return activationState.Context.Services.GetRequiredService<MainWindow>();
    }
}

