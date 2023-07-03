using System;
namespace MauiWindowScopeSample
{
	public class ScopedService : IDisposable
	{
		public ScopedService()
		{
		}

		~ScopedService()
		{
			Console.WriteLine("ScopedService.Finalize");
		}

        public void Dispose()
        {
			Console.WriteLine("ScopedService.Dispose");
        }
    }
}

