using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = "OOXX666XSOSX23452342SOSOO777XXSSS";
			
			Console.WriteLine(Business.Drone.Evaluate(input));
			Console.Read();
		}
	}
}
