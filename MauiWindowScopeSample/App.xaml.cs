namespace MauiWindowScopeSample;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
	}

    protected override Window CreateWindow(IActivationState activationState)
    {
		return activationState.Context.Services.GetRequiredService<MainWindow>();
    }
}

