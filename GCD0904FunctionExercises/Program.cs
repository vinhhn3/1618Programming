using System;

namespace GCD0904FunctionExercises
{
	class Program
	{
		// Sign of Integer Number
		static void PrintSign(int number)
		{
			if (number > 0)
			{
				Console.WriteLine($"The number {number} is positive");
			}
			else if (number < 0)
			{
				Console.WriteLine($"The number {number} is negative");
			}
			else
			{
				Console.WriteLine($"The number {0} is zero");
			}
		}

		//	Problem: Grades
		//	Write a method that receives a grade between 2.00 and 6.00
		//	and prints the corresponding grade in words
		//	2.00 - 2.99 - "Fail"
		//	3.00 - 3.49 - "Poor"
		//	3.50 - 4.49 - "Good"
		//	4.50 - 5.49 - "Very good"
		//	5.50 - 6.00 - "Excellent"
		//	Else - "Invalid mark"
		static void PrintGrade(double mark)
		{
			if (mark >= 2.00 && mark <= 2.99)
			{
				Console.WriteLine("Fail");
			}
			else if (mark >= 3.00 && mark <= 3.49)
			{
				Console.WriteLine("Poor");
			}
			else if (mark >= 3.50 && mark <= 4.49)
			{
				Console.WriteLine("Good");
			}
			else if (mark >= 4.50 && mark <= 5.49)
			{
				Console.WriteLine("Very Good");
			}
			else if (mark >= 5.50 && mark <= 6.00)
			{
				Console.WriteLine("Excellent");
			}
			else
			{
				Console.WriteLine("Invalid Mark");
			}
		}

		//	Problem: Printing Triangle
		static void PrintTriangle(int size)
		{
			PrintFirstHalfTriangle(size);
			PrintSecondHalfTraingle(size);
		}

		static void PrintFirstHalfTriangle(int size)
		{
			for (int i = 1; i <= size; i++)
			{
				PrintLine(i);
			}
		}

		static void PrintSecondHalfTraingle(int size)
		{
			for (int i = size - 1; i >= 1; i--)
			{
				PrintLine(i);
			}
		}

		static void PrintLine(int size)
		{
			for (int i = 1; i <= size; i++)
			{
				Console.Write(i + " ");
			}
			Console.WriteLine();
		}

		static void Main(string[] args)
		{
			//	Sign of integer number
			PrintSign(10);
			PrintSign(-10);
			PrintSign(0);

			// Problem: Grades
			PrintGrade(1.00);
			PrintGrade(2.40);
			PrintGrade(3.40);
			PrintGrade(4.40);
			PrintGrade(5.40);
			PrintGrade(5.80);
			PrintGrade(6.40);

			//	Problem: Printing Triangle
			PrintLine(3);
			PrintLine(4);
			PrintFirstHalfTriangle(3);
			PrintSecondHalfTraingle(3);

			PrintTriangle(4);

			Console.ReadLine();
		}
	}
}
