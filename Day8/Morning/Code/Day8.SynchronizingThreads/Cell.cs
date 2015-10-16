using System;
using System.Threading;

namespace Day8.SynchronizingThreads
{

	public class Cell
	{
		int cellContents;         // Cell contents
		bool readerFlag = false;  // State flag
		public int ReadFromCell( )
		{
			lock(this)   // Enter synchronization block
			{
				if (!readerFlag)
				{            // Wait until Cell.WriteToCell is done producing
					try
					{
						// Waits for the Monitor.Pulse in WriteToCell
						Monitor.Wait(this);
					}
					catch (SynchronizationLockException e)
					{
						Console.WriteLine(e);
					}
					catch (ThreadInterruptedException e)
					{
						Console.WriteLine(e);
					}
				}
				Console.WriteLine("Consume: {0}",cellContents);
				readerFlag = false;    // Reset the state flag to say consuming
				// is done.
				Monitor.Pulse(this);   // Pulse tells Cell.WriteToCell that
				// Cell.ReadFromCell is done.
			}   // Exit synchronization block
			return cellContents;
		}
		public void WriteToCell(int n)
		{
			lock(this)  // Enter synchronization block
			{
				if (readerFlag)
				{      // Wait until Cell.ReadFromCell is done consuming.
					try
					{
						Monitor.Wait(this);   // Wait for the Monitor.Pulse in
						// ReadFromCell
					}
					catch (SynchronizationLockException e)
					{
						Console.WriteLine(e);
					}
					catch (ThreadInterruptedException e)
					{
						Console.WriteLine(e);
					}
				}
				cellContents = n;
				Console.WriteLine("Produce: {0}",cellContents);
				readerFlag = true;    // Reset the state flag to say producing
				// is done
				Monitor.Pulse(this);  // Pulse tells Cell.ReadFromCell that 
				// Cell.WriteToCell is done.
			}   // Exit synchronization block
		}
	}
}

