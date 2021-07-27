using System;
using System.Collections.Generic;
using System.Linq;

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

			// Insert
			names.Insert(3, "Lara Croft");
			for (int i = 0; i < names.Count; i++)
			{
				// List: can use index like array to read value
				Console.WriteLine(names[i]);
			}

			// Reading Lists from the Console
			// Method 1: Use "for" loop
			// First, read from the console the list length:
			int n = int.Parse(Console.ReadLine());

			// Next, create a list of given size n and read its elements:
			List<int> list = new List<int>();
			for (int i = 0; i < n; i++)
			{
				int number = int.Parse(Console.ReadLine());
				list.Add(number);
			}

			Console.WriteLine("Display all values in list");
			foreach (var item in list)
			{
				Console.WriteLine(item);
			}

			Console.ReadLine();


			// Method 2: LINQ
			string values = Console.ReadLine();
			List<string> listValues = values.Split(' ').ToList();

			List<int> numbers = new List<int>();
			foreach (var item in listValues)
			{
				numbers.Add(int.Parse(item));
			}


			// Method 3: God Mode
			numbers = Console.ReadLine().Split(' ')
				.Select(int.Parse).ToList();

			// Sorting Lists
			names = new List<string>()
			{
				"John Wick",
				"John Paul",
				"Harry Potter",
				"Mr. Bean",
				"Bruce Wayne"
			};

			Console.WriteLine("Soring by ascending");
			names.Sort(); // Sorting by ascending
			foreach (var item in names)
			{
				Console.WriteLine(item);
			}

			Console.WriteLine("Soring by descending");
			names.Reverse();  // Sorting by descending
			foreach (var item in names)
			{
				Console.WriteLine(item);
			}

			Console.ReadLine();
		}
	}
}




