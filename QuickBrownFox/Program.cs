namespace QuickBrownFox
{
	internal class Program
	{
		private const int MIN = 1;
		private const int MAX = 50;

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
				else
				{
                    Console.WriteLine("missing");
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
			string symbols = " .,?!`\"";
			char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
			var letters = phrase.Trim().ToLower().ToCharArray();

			for (int i = 0; i < phrase.Length; i++)
			{
				foreach (var l in letters)
				{
					if (!symbols.Contains(l) && !alphabet.Contains(l))
					{
						return false;
					}
				}
			}

			return true;
		}
	}
}
