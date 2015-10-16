using System;
using System.Linq;
using System.Threading;
using System.Collections.Concurrent;


namespace Day8.ConcurrentExample
{	
	class Program
	{
		static ConcurrentDictionary<string, int> _concurrent =
			new ConcurrentDictionary<string, int>();

		static void Main()
		{
			Thread thread1 = new Thread(new ThreadStart(A));
			Thread thread2 = new Thread(new ThreadStart(A));
			thread1.Start();
			thread2.Start();
			thread1.Join();
			thread2.Join();
			Console.WriteLine("Average: {0}", _concurrent.Values.Average());
		}

		static void A()
		{
			for (int i = 0; i < 1000; i++)
			{
				_concurrent.TryAdd(i.ToString(), i);
			}
		}
	}
}
