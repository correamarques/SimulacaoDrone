﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = "OOXXSOSXSOSOOXXSSS";

			Console.WriteLine(Business.Drone.Evaluate(input));
			Console.Read();
		}
	}
}
