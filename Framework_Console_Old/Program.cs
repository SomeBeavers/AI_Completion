using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework_Console_Old
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			if (args == null) return;
			foreach (var arg in args)
			{
				Console.WriteLine(arg);
			}

			// Create a new instance of Person
			Person person = new Person();
			Console.WriteLine($"Created a new Person instance: {person}");

		}
	}
}
