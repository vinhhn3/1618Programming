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
		static void Main(string[] args)
		{
			//	Sign of integer number
			PrintSign(10);
			PrintSign(-10);
			PrintSign(0);



			Console.ReadLine();
		}
	}
}
