using Android.App;
using Android.Content.PM;
using Android.OS;
using Microsoft.Maui.Platform;

namespace MauiWindowScopeSample;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnDestroy()
    {
        //var window = this.GetWindow();
        //window.Destroying();
        base.OnDestroy();
    }
}

