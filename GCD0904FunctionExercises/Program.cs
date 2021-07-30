﻿using System;

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

		static void PrintTriangle2ndVersion(int size)
		{
			for (int i = 1; i <= size; i++)
			{
				for (int j = 1; j <= i; j++)
				{
					Console.Write(j + " ");
				}
				Console.WriteLine();
			}

			for (int x = size - 1; x >= 1; x--)
			{
				for (int y = 1; y <= x; y++)
				{
					Console.Write(y + " ");
				}
				Console.WriteLine();
			}
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

		//	Problem: Calculate Rectangle Area
		static double CalculateRectangleArea(double height, double width)
		{
			if (height <= 0 || width <= 0)
			{
				Console.WriteLine("Invalid input(s) ...");
				return -1;
			}
			return height * width;
		}

		// Problem: Repeat String
		static string RepeatString(string str, int time)
		{
			if (time <= 0)
			{
				Console.WriteLine("Invalid time ...");
				return "";
			}
			string result = str;
			int i = 1;
			while (i < time)
			{
				result = result + str;
				i++;
			}

			return result;
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
			PrintTriangle2ndVersion(4);

			//	Problem: Calculate Rectangle Area
			Console.WriteLine(CalculateRectangleArea(1.00, 2.34));
			Console.WriteLine(CalculateRectangleArea(2.43, 12.34));
			Console.WriteLine(CalculateRectangleArea(0.00, -1.00));
			Console.WriteLine(CalculateRectangleArea(-1.00, 2.34));

			// Problem: Repeat String
			Console.WriteLine(RepeatString("abc", 3));
			Console.WriteLine(RepeatString("String", 4));
			Console.WriteLine(RepeatString("String", 0));
			Console.WriteLine(RepeatString("String", -1));

			Console.ReadLine();
		}
	}
}
