using Android.App;
using Android.Content;
using Android.Runtime;

namespace MauiWindowScopeSample;

[Application]
public class MainApplication : MauiApplication
{
	public MainApplication(IntPtr handle, JniHandleOwnership ownership)
		: base(handle, ownership)
	{
	}

	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();


    public override void OnCreate()
    {
        base.OnCreate();

        var intent = new Intent(Context, typeof(MyForegroundService));
        intent.SetAction(MyForegroundService.StartServiceIntentAction);
        Context.StartForegroundService(intent);
    }
}

