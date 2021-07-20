using System;

namespace GCD0904.BasicSyntax
{
	class Program
	{
		static void Main(string[] args)
		{
			// Display "Hello World" to screen
			Console.WriteLine("Hello World");

			// Declaring variables
			// {data type} {variable_name} = {value}
			int number = 5;
			Console.WriteLine(number);

			// Read input from keyboard
			Console.Write("Enter your name: ");
			string fullName = Console.ReadLine();

			// Display values to screen
			Console.WriteLine(fullName);
			Console.WriteLine("Welcome " + fullName);

			Console.Write("Enter your age: ");
			int age = int.Parse(Console.ReadLine()); // Convert string to int
			Console.WriteLine("Welcome: {0}, your age is: {1}", fullName, age);
			Console.WriteLine($"Welcome {fullName}, your age is: {age}");

			Console.ReadLine();
		}
	}
}
