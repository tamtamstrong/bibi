using System;

namespace Bibi
{
	public class Robot
	{
		private bool currentInput;

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

			}
		}

		public Robot ()
		{
		}
	}
}

