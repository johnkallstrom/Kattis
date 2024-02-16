namespace NoDuplicates
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string input = ReadInput();
			string[] words = input.Split(" ");

			bool result = IsDuplicated(words);
			if (result)
			{
				Console.WriteLine("no");
			}
			else
			{
				Console.WriteLine("yes");
			}
		}

		static string ReadInput()
		{
			while (true)
			{
				var input = Console.ReadLine();

				if (!string.IsNullOrEmpty(input) && IsValid(input))
				{
					return input;
				}
			}
		}

		static bool IsValid(string value)
		{
			if (string.IsNullOrWhiteSpace(value)) return false;
			if (value.Length >= 80) return false;

			var words = value.Split(" ");
			foreach (var w in words)
			{
				if (IsWordUpper(w) == false)
				{
					return false;
				}
			}

			return true;
		}

		static bool IsWordUpper(string word)
		{
			var characters = word.ToCharArray();

			foreach (var c in characters)
			{
				if (!char.IsUpper(c))
				{
					return false;
				}
			}

			return true;
		}

		static bool IsDuplicated(string[] words)
		{
			var previousWords = new List<string>();
			string current = "";

			foreach (var w in words)
			{
				string previous = current;

				if (!string.IsNullOrEmpty(previous))
				{
					previousWords.Add(previous);
				}

				current = w;

				if (previousWords.Contains(current))
				{
					return true;
				}
				else
				{
					continue;
				}
			}

			return false;
		}
	}
}