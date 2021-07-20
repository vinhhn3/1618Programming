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

			// Formatting numbers with placeholders
			double salary = 123.45678;
			Console.WriteLine(salary);
			Console.WriteLine("{0:F2}", salary);
			Console.WriteLine("{0:F3}", salary);
			Console.WriteLine("{0:F4}", salary);

			// Student Information solution
			Console.WriteLine("Enter student information below");
			string studentName = Console.ReadLine();
			int studentAge = int.Parse(Console.ReadLine());
			double averageGrade = double.Parse(Console.ReadLine());
			Console.WriteLine("Student Information");
			Console.WriteLine($"Name: {studentName}, Age: {studentAge}, Grade: {averageGrade}");

			// Comparison Operators
			// > < <= >= == != 
			Console.WriteLine("=====Comparison Operators=====");

			int numberA = 10;
			int numberB = 20;

			Console.WriteLine(numberA < numberB);   // true
			Console.WriteLine(numberA > numberB);   // false
			Console.WriteLine(numberA <= numberB);  // true
			Console.WriteLine(numberA >= numberB);  // false
			Console.WriteLine(numberA == numberB);  // false
			Console.WriteLine(numberA != numberB);  // true

			// If statements

			// if (condition)
			// {
			//	 doSomething();	
			// }

			Console.WriteLine("=====IF STATEMENTS=====");

			double grade = 6.5;
			if (grade < 6.5)
			{
				Console.WriteLine("Failed !!!");
			}

			if (grade >= 6.5)
			{
				Console.WriteLine("Passed !!!");
			}

			Console.WriteLine("=====if ...else if ... else STATEMENTS=====");
			// if (condition_1)
			// {
			//	 doSomething();
			// }
			// else if (condition_2)
			// {
			//	 doSomethingMore();
			// }
			// else
			// {
			//	 doSomething();
			// }

			// Ctrl + k + c => comment
			// Ctrl + k + u => uncomment
			Console.Write("Enter your grade: ");
			grade = double.Parse(Console.ReadLine());

			if (grade < 0)
			{
				Console.WriteLine("ERROR !!!");
			}
			else if (grade < 6.5)
			{
				Console.WriteLine("Failed !!!");
			}
			else if (grade < 8)
			{
				Console.WriteLine("Passed !!!");
			}
			else if (grade < 10)
			{
				Console.WriteLine("Merit !!!");
			}
			else if (grade == 10)
			{
				Console.WriteLine("Distinction !!!");
			}
			else
			{
				Console.WriteLine("ERROR !!!");
			}

			// Back in 30 minutes
			int hour = int.Parse(Console.ReadLine());
			int minutes = int.Parse(Console.ReadLine());

			// minutes: 46 + 30 = 76 - 60 = 16
			// hour: 1 + 1 = 2

			// minutes: 20 + 30 = 50
			// hour: 1
			minutes = minutes + 30;
			if (minutes >= 60)
			{
				minutes = minutes - 60;
				hour = hour + 1;
			}

			if (hour == 24)
			{
				hour = 0;
			}

			Console.WriteLine($"Hour: {hour}, Minutes: {minutes}");


			Console.ReadLine();
		}
	}
}
