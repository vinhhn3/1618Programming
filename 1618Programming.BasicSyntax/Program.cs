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

			Console.WriteLine("====Switch case statement====");

			// switch-case statement
			// switch (variable)
			// {
			//	 case value_1:
			//		 doSomething();
			//		 break;

			//	 case value_2:
			//		 doSomething();
			//		 break;

			//	 default:
			//		 break;
			// }

			int month = int.Parse(Console.ReadLine());

			switch (month)
			{
				case 1:
					Console.WriteLine("Jan");
					break;
				case 2:
					Console.WriteLine("Feb");
					break;
				case 3:
					Console.WriteLine("Mar");
					break;
				case 4:
					Console.WriteLine("Apr");
					break;
				case 5:
					Console.WriteLine("May");
					break;
				case 6:
					Console.WriteLine("June");
					break;
				case 7:
					Console.WriteLine("July");
					break;
				case 8:
					Console.WriteLine("Aug");
					break;
				case 9:
					Console.WriteLine("Sep");
					break;
				case 10:
					Console.WriteLine("Oct");
					break;
				case 11:
					Console.WriteLine("Nov");
					break;
				case 12:
					Console.WriteLine("Dec");
					break;
				default:
					Console.WriteLine("INVALID INPUT !!!");
					break;
			}

			// Logical Operators
			// NOT: !
			// AND: &&
			// OR: ||
			// ======
			// Logical value: True, False
			// ======
			// NOT: 
			// !True => False
			// !False => True
			// AND: True when everything is true, else False
			// True && True => True
			// True && False => False
			// False && True => False
			// False && False => False
			// OR: False when everthing is false, else True
			// True || True => True
			// True || False => True
			// False || True => True
			// False || False => False

			bool gateA = true;
			Console.WriteLine(!gateA);    // NOT(true) => False

			bool gateB = false;

			Console.WriteLine(gateA && gateB);  // true AND false => false
			Console.WriteLine(gateA && gateA);  // true AND true => true

			Console.WriteLine(gateA || gateB);  // true OR false => true
			Console.WriteLine(gateB || gateB);  // false OR false => false

			// Theatre Promotions
			string datetype = Console.ReadLine();
			int customerAge = int.Parse(Console.ReadLine());
			int ticketPrice = 0;

			switch (datetype)
			{
				case "Weekday":
					if (customerAge >= 0 && customerAge <= 18)
					{
						ticketPrice = 12;
					}
					else if (customerAge > 18 && customerAge <= 64)
					{
						ticketPrice = 18;
					}
					else if (customerAge < 64 && customerAge <= 122)
					{
						ticketPrice = 12;
					}
					break;

				case "Weekend":
					if (customerAge >= 0 && customerAge <= 18)
					{
						ticketPrice = 15;
					}
					else if (customerAge > 18 && customerAge <= 64)
					{
						ticketPrice = 20;
					}
					else if (customerAge < 64 && customerAge <= 122)
					{
						ticketPrice = 15;
					}
					break;

				case "Holiday":
					if (customerAge >= 0 && customerAge <= 18)
					{
						ticketPrice = 5;
					}
					else if (customerAge > 18 && customerAge <= 64)
					{
						ticketPrice = 12;
					}
					else if (customerAge < 64 && customerAge <= 122)
					{
						ticketPrice = 10;
					}
					break;
				default:
					ticketPrice = -1;
					Console.WriteLine("Error !!!");
					break;
			}

			Console.WriteLine(ticketPrice);

			// FOR loops
			// for (int i = initValue; i < endedValue; i++)
			// {
			//	doSomething();
			// }
			int i;

			for (i = 1; i < 10; i = i + 1)
			{

				Console.WriteLine(i);
			}
			int j;

			for (j = 10; j > 0; j--)
			{
				Console.WriteLine(j);
			}

			// WHILE loops
			// while (condition)
			// {
			//	 doSomething();
			// }

			i = 1;
			while (i < 10)
			{
				Console.WriteLine(i);
				i = i + 1;
			}

			j = 10;
			while (j > 0)
			{
				Console.WriteLine(j);
				j = j - 1;
			}

			// Calcuate factorial of number n
			int n = int.Parse(Console.ReadLine());
			int result = 1;

			if (n == 0)
			{
				result = 1;
			}
			else
			{
				int index = 0;

				while (index < n)
				{
					result = result * (n - index);
					index = index + 1;
				}
			}

			Console.WriteLine($"Factorial of {n} is: {result}");

			Console.ReadLine();
		}
	}
}
