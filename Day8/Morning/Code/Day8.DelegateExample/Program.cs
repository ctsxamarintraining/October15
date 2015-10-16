using System;

namespace Day8.DelegateExample
{
	class MainClass
	{
//		public static void Main (string[] args)
//		{
//			WhatINeedToDo d1 = new WhatINeedToDo (IhaveToDoThis);
//			WhatINeedToDo d2 = new WhatINeedToDo (IhaveToDoThis1);
//			WhatINeedToDo md = d1;
//			md += d2;
//
//			MainClass c = new MainClass ();
//			MathTest mathTest = new MathTest ();
//			mathTest.Add (2, 5, c.IhaveToDoThis);
//			Console.ReadLine ();
//		}

		public static void Main (string[] args)
		{
			MathTest m = new MathTest ();
			m.OnMathEnd += (object sender, MathEventArgs e) => {
				Console.WriteLine(e.Result.ToString());
			};
			m.Diff (10,3);
			Console.ReadLine ();
		}

		public void IhaveToDoThis(object obj)
		{
			Console.WriteLine (obj.ToString());
		}
		public void IhaveToDoThis1(object obj)
		{
			Console.WriteLine (obj.ToString());
		}
	}
}
