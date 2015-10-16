using System;

namespace Day8.DelegateExample
{
	public delegate void WhatINeedToDo(object obj);

	public class MathTest
	{
		public event EventHandler<MathEventArgs> OnMathEnd;

		public void Add(int A,int B, WhatINeedToDo wat)
		{
			int rest = A + B;
			wat (rest);
		}

		public void Diff(int A,int B)
		{
			int rest = A - B;
			if (OnMathEnd != null) {
				OnMathEnd.Invoke (this, new MathEventArgs (rest));
			}
		}
	}

	public class MathEventArgs:EventArgs
	{
		public int Result { get; private set;}

		public MathEventArgs(int result)
		{
			Result = result;
		}

	}
}

