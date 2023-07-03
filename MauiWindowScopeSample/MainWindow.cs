using System;
namespace MauiWindowScopeSample
{
	public class MainWindow : Window
	{
		public MainWindow(ScopedService scopedService) : base(new AppShell())
		{
			GC.Collect(int.MaxValue, GCCollectionMode.Forced, true);
		}

        protected override void OnDestroying()
        {
            base.OnDestroying();
        }
    }
}

