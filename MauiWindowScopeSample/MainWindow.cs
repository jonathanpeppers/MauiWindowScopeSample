using System;
namespace MauiWindowScopeSample
{
	public class MainWindow : Window
	{
		private static int InstanceCount = 0;

		public MainWindow(ScopedService scopedService) : base(new AppShell())
		{
			InstanceCount++;
			LogInstanceCount();
			GC.Collect();
		}

        ~MainWindow()
        {
            InstanceCount--;
            LogInstanceCount();
        }

        private void LogInstanceCount() => Console.WriteLine("MainWindow InstanceCount: {0}", InstanceCount);

        protected override void OnDestroying()
        {
            base.OnDestroying();
            Console.WriteLine("MainWindow.OnDestroying");
        }
    }
}

