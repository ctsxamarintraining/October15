using System;

namespace NullTypeDemo
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Nullable<int> i = null;
			Console.WriteLine (i.HasValue);
			i = 10;
			Console.WriteLine (i.HasValue);
			Console.WriteLine (i.Value);

			int j = 20;
			i = j;
			Console.WriteLine (i);

		}
	}
}
