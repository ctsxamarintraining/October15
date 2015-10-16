using System;
using System.Threading;


namespace Day8.SimpleThread
{	

	public class Simple
	{
		public static void Main()
		{			
			Thread t = new Thread ( WriteY); // Kick off a new thread
			t.Start(); // running WriteY()
			Console.WriteLine(t.ThreadState.ToString());
			//t.Abort ();
			//Console.WriteLine(t.ThreadState.ToString());
			Thread.Sleep(5000);
			// Simultaneously, do something on the main thread.
			for (int i = 0; i < 10; i++) Console.WriteLine ("Current thread {0} X",Thread.CurrentThread.ManagedThreadId);  
		}
		public static void WriteY()
		{
			for (int i = 0; i < 10; i++) {
				Console.WriteLine ("Current thread {0} Y",(int)Thread.CurrentThread.ThreadState); 

			}
		}
	}
}
