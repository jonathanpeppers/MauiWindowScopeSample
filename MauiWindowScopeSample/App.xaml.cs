namespace MauiWindowScopeSample;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
	}

    protected override Window CreateWindow(IActivationState activationState)
    {
        GC.Collect(int.MaxValue, GCCollectionMode.Forced, true);
        return activationState.Context.Services.GetRequiredService<MainWindow>();
    }
}

