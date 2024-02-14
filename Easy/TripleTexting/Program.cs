using System;
using System.Linq;

namespace TripleTexting
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string input = ReadInput();
			string result = FindOriginalWord(input);

			Console.WriteLine(result);
		}

		static string ReadInput()
		{
			while (true)
			{
				string input = Console.ReadLine();

				if (Valid(input))
				{
					return input;
				}
			}
		}

		static string FindOriginalWord(string input)
		{
			throw new NotImplementedException();
		}

		static bool Valid(string input)
		{
			if (!string.IsNullOrEmpty(input)
				&& IsBetween(input, 3, 99)
				&& IsOneSentence(input)
				&& OnlyLowercase(input))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		static bool IsBetween(string value, int min, int max)
		{
			if (value.Length >= min && value.Length <= max)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		static bool IsOneSentence(string value)
		{
			if (value.Split(" ").Count() == 1)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		static bool OnlyLowercase(string value)
		{
			foreach (var c in value.ToArray())
			{
				if (char.IsLower(c) == false)
				{
					return false;
				}
			}

			return true;
		}
	}
}
