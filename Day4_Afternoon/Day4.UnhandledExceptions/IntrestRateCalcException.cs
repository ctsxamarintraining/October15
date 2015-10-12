using System;

namespace Day4.UnhandledExceptions
{
	public class IntrestRateCalcException : ApplicationException
	{		
		public IntrestRateCalcException () : base("Invalid intrest rate.")
		{
		}
		public IntrestRateCalcException (string error) : base(error)
		{
		}
	}
}

