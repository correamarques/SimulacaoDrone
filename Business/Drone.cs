using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Business
{
	public class Drone
	{
		public static string Evaluate(string input)
		{
			try
			{
				if (!IsAlphanumeric(input))
					throw new Exception("(999, 999)");

				//The input does not have X nor number
				if (!HasX(input) && !HasNumber(input))
					return SimpleSum(input);

				string retorno = string.Empty;
				if (HasX(input) && !HasNumber(input))
					return SumWithX(input);

				if (HasX(input) && HasNumber(input))
					return SumNumber(retorno);

				return SimpleSum(retorno);
			}
			catch (Exception e)
			{
				return e.Message;
			}
		}

		private static string SumNumber(string input)
		{
			try
			{
				string filteredInput = RemoveX(input);
				filteredInput = RemoveNumbers(input);

				return SimpleSum(filteredInput);
			}
			catch (Exception)
			{
				throw;
			}
		}

		static string RemoveX(string input)
		{
			try
			{
				if (input[0] == 'X')
					throw new Exception("(999, 999)");

				string filteredInput = string.Empty;
				//Lê todos os characteres
				for (int index = 0; index < input.Length; index++)
				{// para facilitar o debug carrega o char atual
					char c = input[index];

					if (c == 'X' && filteredInput.Length > 0)
						filteredInput = filteredInput.Remove(filteredInput.Length - 1, 1);
					else if (c == 'X' && filteredInput.Length == 0)
						throw new Exception("(999, 999)");
					else
						filteredInput += c;
				}
				return filteredInput;
			}
			catch (Exception)
			{
				throw;
			}
		}

		static string RemoveNumbers(string input)
		{// Agrupa os números
			foreach (var item in Regex.Matches(input, @"\d{1,10}"))
			{
				Console.WriteLine(item);
			}

			throw new NotImplementedException();
		}

		private static string SumWithX(string input)
		{
			try
			{
				string filteredInput = RemoveX(input);

				return SimpleSum(filteredInput);
			}
			catch (Exception)
			{
				throw;
			}
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
