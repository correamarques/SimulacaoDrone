using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Business
{
    public class Drone
    {
		public static string Evaluate(string input)
		{
			if (!IsAlphanumeric(input))
				return "(999, 999)";

			//The input does not have X nor number
			if (!HasX(input) && !HasNumber(input))
				return SimpleSum(input);

			if (HasX(input) && !HasNumber(input))
				return SumWithX(input);


			return HasX(input).ToString();
		}

		private static string SumWithX(string input)
		{
			throw new System.NotImplementedException();
		}

		/// <summary>
		/// Search on the input to find an invalid character
		/// </summary>
		/// <param name="input">Position</param>
		/// <returns>True or false</returns>
		private static bool IsAlphanumeric(string input)
		{
			return Regex.Matches(input, "^[A-Za-z0-9]+$").Count > 0;
		}


		static string SimpleSum(string input)
		{// Filter chars on input
			IEnumerable<char> charList = input.Distinct();
			List<int> charCount = new List<int>();

			foreach (char item in charList)
			{
				//Conta a quantidade de caracteres repetidos
				int count = input.Count(i => i == item);
				
				// Sul ou Oeste deve ter posição negativa no gráfico
				if (item == 'S' || item == 'O')
					charCount.Add(count * -1);
				else
					charCount.Add(count);
			}

			return TheDronePointIs(charCount[0], charCount[1]);
		}

		static string TheDronePointIs(int positionX, int positionY)
		{
			return string.Format("({0}, {1})", positionX, positionY);
		}

		static bool HasX(string input)
		{
			return Regex.Matches(input, "[X|x]").Count > 0;
		}
		static bool HasNumber(string input)
		{
			return Regex.Matches(input, @"\d").Count > 0;
		}
    }
}
