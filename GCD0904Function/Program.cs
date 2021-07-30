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

		static int SumTwoNumbers(int a, int b)
		{
			int result = a + b;
			return result;
		}

		static int SumThreeNumbers(int a, int b, int c)
		{
			int result = a + b + c;
			result = SumTwoNumbers(a, SumTwoNumbers(b, c));
			// a + b + c
			// = a + (b + c)
			// = a + SumTwoNumbers(b, c)
			// = SumTwoNumbers(a, SumTwoNumbers(b, c))

			return result;
		}

		static void Main(string[] args)
		{
			int numberA = 10;
			int numberB = 20;
			// Call function SumTwoNumbers(int a, int b)
			int sum = SumTwoNumbers(numberA, numberB);
			int numberC = 30;
			sum = SumThreeNumbers(numberA, numberB, numberC);

			Console.WriteLine(sum);

			Console.ReadLine();
		}
	}
}
