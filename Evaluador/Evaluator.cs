using System;
using System.Collections;

namespace Za.Evaluator
{
	/// <summary>
	/// Summary description for Evaluator.
	/// </summary>
	public class Evaluator 
	{
		public Evaluator():base(){}
		
		public static Variant Evaluate(String s)
		{
			ExecutionQueue eq = ParseIt(s);
			return CalcIt(eq);
		}

		public static ExecutionQueue ParseIt(string s)
		{
			Parser p = new Parser();
			p.ParseIt(s);
			return p.eqResult;
		}

		public static Variant CalcIt(ExecutionQueue eq)
		{
			Calculator c = new Calculator();
			return c.CalcIt(eq);
		}

		public static Hashtable Variables
		{
			get
			{
				return Calculator.Variables;
			}
			set
			{
				Calculator.Variables = value;
			}
		}

	
	}
}
