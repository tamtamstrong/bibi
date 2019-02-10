using System;

namespace Bibi
{
	public class Robot
	{
		private bool currentInput;
		private bool currentOutput;

		public bool Input
		{ 
			get
			{
				return currentInput;
			}
			set
			{
				currentInput = value;
			}
		}

		public bool Output 
		{ 
			get
			{
				return currentInput;
			}

			private set
			{
				currentOutput = value;
			}
		}

		public Robot ()
		{
		}
	}
}

