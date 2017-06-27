using System;

namespace sieve_of_erathostenes
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int l = Convert.ToInt32 (Console.ReadLine());

			int[] num = new int[l - 1];

			for (int i = 0; i < l - 1; i++)	
				num [i] = i + 2;

			for (int i = 2; i <= Math.Sqrt (l - 1); i++) {
				for (int j = 0; j < num.Length; j++) {
					if (num [j] % i == 0 && num [j] != i)
						num [j] = 0;
				}
			}

			string s = "";
			int a = l.ToString ().Length;
			int br = 2;

			Console.Write (addChar('0', a) + " ");

			for (int i = 0; i < num.Length; i++) {
				s = "";

				if (num [i] < 10)
					s += addChar ('0', a - 1);
				else if (num [i] < 100)
					s += addChar ('0', a - 2);
				else if (num [i] < 1000)
					s += addChar ('0', a - 3);
				else if (num [i] < 10000)
					s += addChar ('0', a - 4);

				s += num[i];

				Console.Write (s + " ");

				if (br == 10) {
					br = 0;

					Console.WriteLine ();
				}

				br++;
			}
		}

		private static string addChar(char character, int repeat) {
			string ret = "";

			for (int i = 0; i < repeat; i++)
				ret += character;

			return ret;
		}
	}
}
