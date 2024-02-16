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
				string phrase = ReadString();
				var missing = GetMissingLetters(phrase);

				if (missing.Count() > 0)
				{
                    Console.WriteLine($"missing {new string(missing)}");
                }
				else
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

		static char[] GetMissingLetters(string phrase)
		{
			var matches = new List<char>();

			foreach (var letter in phrase.ToLower())
			{
				if (SYMBOLS.Contains(letter) || DIGITS.Contains(letter))
				{
					continue;
				}

				if (ALPHABET.Contains(letter))
				{
					matches.Add(letter);
				}
			}

			return ALPHABET.Except(matches).ToArray();
		}
	}
}
