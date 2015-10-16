using System;

namespace Day8.SynchronizingThreads
{
	public class CellCons
	{
		Cell cell;         // Field to hold cell object to be used
		int quantity = 1;  // Field for how many items to consume from cell

		public CellCons(Cell box, int request)
		{
			cell = box;          // Pass in what cell object to be used
			quantity = request;  // Pass in how many items to consume from cell
		}
		public void ThreadRun( )
		{
			int valReturned = 0;
			for (int looper = 1; looper <= quantity; looper++) {
				// Consume the result by placing it in valReturned.
				valReturned = cell.ReadFromCell ();
			}
		}
	}

}

