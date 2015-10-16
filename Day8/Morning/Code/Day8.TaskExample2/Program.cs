using System;
using System.Threading.Tasks;
using System.Threading;

namespace Day8.TaskExample2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Action<object> action = (object obj) =>
			{
				int i = 0;
				int res = 10/i;

				Console.WriteLine("Task={0}, obj={1}, Thread={2}",
					Task.CurrentId, obj,
					Thread.CurrentThread.ManagedThreadId);
				
			};

			Task t2 = Task.Factory.StartNew(action, "beta");
			t2.Wait ();

			if (t2.IsFaulted)
				Console.WriteLine (t2.Exception.Message);
			
			Console.ReadLine ();
		}
	}
}
