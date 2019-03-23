using System;
using System.Text;

namespace bibi
{
	class MainClass
	{
		static Random random = new Random ();
		static StringBuilder sb = new StringBuilder ();
		static int difficultyLevel = 0;
		static int displayTimeInMilliseconds = 300;

		public static void Main (string[] args)
		{
			Console.WriteLine ("Watch carefully then repeat the string!");
			SetDifficulty ();
			Console.WriteLine ("Press any key to start!");
			Console.ReadKey ();
			Console.Clear ();

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

			Console.WriteLine (string.Format ("You scored {0} on a difficulty level of {1}", score, difficultyLevel));
		}

		static void SetDifficulty ()
		{
			Console.WriteLine ("Choose difficulty level (1 = easiest, 5 = hardest):");
			bool difficultyWasSet = false;
			do
			{
				string input = Console.ReadLine ();
				if (int.TryParse(input, out difficultyLevel) && difficultyLevel >= 1 && difficultyLevel <= 5)
				{
					difficultyWasSet = true;
				}
				else
				{
					Console.WriteLine("You must enter an integer between 1 and 5!");
				}
			}
			while (!difficultyWasSet);
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
			switch(difficultyLevel)
			{
				case 1: displayTimeInMilliseconds = 2000; break;
				case 2: displayTimeInMilliseconds = 1500; break;
				case 3: displayTimeInMilliseconds = 1000; break;
				case 4: displayTimeInMilliseconds = 500; break;
				case 5: displayTimeInMilliseconds = 200; break;
				default: displayTimeInMilliseconds = 1000; break;
			};

			Console.WriteLine (toOutput);
			System.Threading.Thread.Sleep (displayTimeInMilliseconds);
			Console.Clear ();
		}

		static string GetInputString ()
		{
			string input = Console.ReadLine ();
			Console.Clear ();
			return input;
		}
	}
}
