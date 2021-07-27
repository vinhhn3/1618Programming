using System;

namespace GCD0904ArrayAndList
{
	class Program
	{
		static void Main(string[] args)
		{
			int arrayLength = 10;
			// Syntax create array
			// DataType[] arrayName = new DateType[]
			int[] numbers = new int[arrayLength]; // Create array with datatype int
			double[] realNumbers = new double[arrayLength];

			//int index = 0;
			//numbers[index] = 10; // Assign value 10 to numbers[0]
			//Console.WriteLine($"Value of numbers[0] is: {numbers[0]}");

			// Assign value: arrayName[index] = value
			// Read value from index: Console.WriteLine(arrayName[index]);

			for (int i = 0; i < numbers.Length; i++)
			{
				numbers[i] = i + 20;
				Console.WriteLine($"Value of numbers[{i}] is: {numbers[i]}");
			}

			// Exception because 100 > length of array numbers (10)
			// Array: static
			// numbers[100] = 20;

			// Days of Week 
			// Declare array and assign values
			string[] days = {
				"Monday",			// index = 0
				"Tuesday",		// index = 1
				"Wednesday",	// index = 2
				"Thursday",		// index = 3
				"Friday",     // index = 4
				"Saturday",		// index = 5
				"Sunday"			// index = 6
			};

			int dayInput = int.Parse(Console.ReadLine());
			if (dayInput >= 1 && dayInput <= 7)
			{
				Console.WriteLine(days[dayInput - 1]);
			}
			else
			{
				Console.WriteLine("Invalid Input ...");
			}

			//string[] days = new string[7];
			//days[0] = "Monday";
			//days[1] = " Tuesday";


			Console.ReadLine();
		}
	}
}
