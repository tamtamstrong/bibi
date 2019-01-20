using System;
using System.Threading;

namespace Bibi
{
	class BibiIO
	{
		public static void Main (string[] args)
		{
			Robot robot = new Robot ();

			// read from stdin in a loop until any key other than 1 or 0 is encountered or the end of input
			const int bpm = 60;
			int millisecondsBetweenBeats = 1000 * 60 / bpm;
			int inputCode;
			Char inputChar;

			do
			{
				inputCode = Console.Read ();
				if (inputCode == -1)
				{
					Console.WriteLine("end of input");
					break;
				}

				try
				{
					inputChar = Convert.ToChar (inputCode);
				}
				catch (OverflowException)
				{
					Console.WriteLine("invalid char");
					break;
				}

				if (inputChar != '0' && inputChar != '1')
				{
					Console.WriteLine("non binary char");
					break;
				}

				Console.WriteLine(robot.Output ? 1 : 0);
				robot.Input = inputChar == '1' ? true : false;
				Thread.Sleep (millisecondsBetweenBeats);
			}
			while(true);
		}
	}
}
