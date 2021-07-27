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
			numbers[100] = 20;

			Console.ReadLine();
		}
	}
}
