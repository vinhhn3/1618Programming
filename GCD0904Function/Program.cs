using System;

namespace GCD0904Function
{
	class Program
	{

		// Function 
		// Repeat code 
		// Function : Input => Process => Result
		// Declare:
		// DataTypeReturn FunctionName (input_1, input_2){
		//	doSomething(); Process
		//	return Result;
		// }



		static int SumThreeNumbers(int a, int b, int c)
		{
			int result = a + b + c;
			result = SumTwoNumbers(a, SumTwoNumbers(b, c));
			// a + b + c
			// = a + (b + c)
			// = a + SumTwoNumbers(b, c)
			// = SumTwoNumbers(a, SumTwoNumbers(b, c))
			return result; // Create new value
		}

		// void type method
		// do not return any new value !!!
		// Use to display to screen
		static void PrintHello()
		{
			Console.WriteLine("Hello World ...");
			Console.WriteLine("Welcome to C# ...");
			Console.WriteLine("CSharp is beautiful ...");
		}

		static void PrintMenu()
		{
			Console.WriteLine("===WELCOME TO MY APP===");
			Console.WriteLine("1. Create new order");
			Console.WriteLine("2. Create payment");
			Console.WriteLine("3. Quit the App");
		}

		static void PrintSum(int sum)
		{
			Console.WriteLine($"sum = {sum}");
		}

		// "return" keyword
		// stop method immediately
		// return value
		static int SumTwoNumbers(int a, int b)
		{
			int result = a + b;
			return result;
		}

		// for void type method
		// return => stop function 
		static void PrintOneToTen()
		{
			for (int i = 1; i <= 10; i++)
			{
				Console.WriteLine(i);

				// When i = 7 => stop function
				if (i == 7)
				{
					return;
				}
			}
		}

		static void Main(string[] args)
		{
			int numberA = 10;
			int numberB = 20;
			// Call function SumTwoNumbers(int a, int b)
			int sum = SumTwoNumbers(numberA, numberB);

			PrintSum(sum);
			int numberC = 30;
			sum = SumThreeNumbers(numberA, numberB, numberC);

			PrintSum(sum);
			PrintHello();

			PrintMenu();

			PrintOneToTen();

			Console.ReadLine();
		}
	}
}
