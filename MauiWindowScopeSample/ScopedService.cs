using System;
namespace MauiWindowScopeSample
{
	public class ScopedService : IDisposable
	{
        private static int InstanceCount = 0;

        public ScopedService()
        {
            InstanceCount++;
            LogInstanceCount();
        }

        ~ScopedService()
        {
            InstanceCount--;
            LogInstanceCount();
        }

        private void LogInstanceCount() => Console.WriteLine("ScopedService InstanceCount: {0}", InstanceCount);

        public void Dispose()
        {
			Console.WriteLine("ScopedService.Dispose");
        }
    }
}

