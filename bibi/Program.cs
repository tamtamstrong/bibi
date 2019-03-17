using System;
using System.Text;

namespace bibi
{
	class MainClass
	{
		static Random random = new Random ();
		static StringBuilder sb = new StringBuilder ();

		public static void Main (string[] args)
		{
			Console.WriteLine ("Watch carefully then repeat the string!");
			Console.WriteLine ("Press any key to start!");
			Console.ReadKey ();

			bool success = false;
			string toRepeat = null;
			string userInput = null;
			int score = 1;

			do
			{
				toRepeat = GenerateString(score);
				OutputString(toRepeat);
				userInput = GetInputString();
				success = toRepeat == userInput;
				score++;
			}
			while(success);
		}

		static string GenerateString (int length)
		{
			sb.Clear ();
			for (int i = 0; i < length; i++)
			{
				sb.Append (random.Next (0, 2));
			}

			return sb.ToString();
		}

		static void OutputString (string toOutput)
		{
			Console.WriteLine (toOutput);
		}

		static string GetInputString ()
		{
			return Console.ReadLine ();
		}
	}
}
