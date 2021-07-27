using System;
using System.Collections.Generic;

namespace GCD0904List
{
	class Program
	{
		static void Main(string[] args)
		{
			// Declare list of names
			List<string> names = new List<string>()
			{
				"John Wick",
				"John Paul",
				"Harry Potter",
				"Mr. Bean",
				"Bruce Wayne"
			};

			foreach (var item in names)
			{
				Console.WriteLine(item);
			}

			// Add more names to list
			names.Add("Tom Perry");
			names.Add("Tony Stark");
			names.Add("Natasha Romanow");

			foreach (var item in names)
			{
				Console.WriteLine(item);
			}

			// Remove name
			names.Remove("John Wick");
			names.Remove("Bruce Wayne");

			for (int i = 0; i < names.Count; i++)
			{
				// List: can use index like array to read value
				Console.WriteLine(names[i]);
			}

			// List: can use index like array to assign value
			names[0] = "John Lennon";
			for (int i = 0; i < names.Count; i++)
			{
				// List: can use index like array to read value
				Console.WriteLine(names[i]);
			}
			Console.ReadLine();
		}
	}
}
