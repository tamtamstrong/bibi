using System;
using System.Threading;

namespace Bibi
{
	class BibiIO
	{
		public static void Main (string[] args)
		{
			int bpm = GetFromArgsOrDefault("bpm", args, 60);
			int millisecondsBetweenBeats = 1000 * 60 / bpm;
			bool input;
			Robot robot = new Robot ();
			IInputGenerator inputGenerator = new InputGenerator ();

			Console.WriteLine ("input | output (press any key to exit)");
			do
			{
				input = inputGenerator.Read ();
				bool robotOutput = robot.Output;
				inputGenerator.Write(robotOutput);
				robot.Input = input;

				Console.WriteLine("{0,-6}|{1,6}", input ? 1 : 0, robotOutput ? 1 : 0);
				if (Console.KeyAvailable)
				{
					Console.WriteLine("Key pressed, stopping.");
					break;
				}
				Thread.Sleep (millisecondsBetweenBeats);
			}
			while(true);
		}

		static int GetFromArgsOrDefault (string paramName, string[] args, int defaultValue)
		{
			// TODO: support -bmp=xxx parameter
			return defaultValue;
		}
	}
}
