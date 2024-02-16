namespace QuickBrownFox
{
	internal class Program
	{
		private const int MIN = 1;
		private const int MAX = 50;

		private static char[] ALPHABET = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
		private static string SYMBOLS = " .,?!`'\"";
		private static string DIGITS = "0123456789";

		static void Main(string[] args)
		{
			int number = ReadInteger();

			for (int i = 1; i <= number; i++)
			{
				string input = ReadString();

				if (IsPangram(input) == true)
				{
                    Console.WriteLine("pangram");
                }
            }
        }

		static int ReadInteger()
		{
			while (true)
			{
				string input = Console.ReadLine();
				if (int.TryParse(input, out int number))
				{
					if (number >= MIN && number <= MAX)
					{
						return number;
					}
				}
				else
				{
					continue;
				}
			}
		}

		static string ReadString()
		{
			while (true)
			{
				string input = Console.ReadLine();

				if (!string.IsNullOrEmpty(input) && input.Length <= 100)
				{
					return input;
				}
				else
				{
					continue;
				}
			}
		}

		static bool IsPangram(string phrase)
		{
			for (int i = 0; i < phrase.Length; i++)
			{
				var letter = phrase[i];

				if (SYMBOLS.Contains(letter) || DIGITS.Contains(letter))
				{
					continue;
				}

                Console.WriteLine(letter);
            }

			return false;
		}
	}
}
