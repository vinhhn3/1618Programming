using System;

namespace GCD0904.DataTypesAndVariables
{
	class Program
	{
		static void Main(string[] args)
		{
			// Declare variable count, type integer
			int count = 5;

			// sbyte vs. byte
			sbyte numberA = 10;
			byte numberB = 20;

			Console.WriteLine($"Number A: {numberA}");
			Console.WriteLine($"Number B: {numberB}");
			// Can't assign negative value to numberB
			// because byte type contains positive value
			// numberB = -10;

			numberB = 252;
			for (sbyte i = 0; i < 10; i++)
			{
				Console.WriteLine(numberB);
				numberB++;
			}

			int a = 10; // a => age of Customer
			int b = 20; // b => price of iPhone

			int customerAge = 10;   // => age of Customer
			int iPhonePrice = 20;   // => price of iPhone

			int tuoiKhachHang = 10; // Do not use Vietnamese for naming variable
			int CustomerAge = 20;   // Do not use PascalCase for local variable
			int Customer_Age = 20;  // Do not use "_"
			int customer_Age = 20;  // Do not use "_"
			int CUSTOMER_AGE = 20;  // Do not use Capital Letter

			// Do not naming like this
			// Variable name must have meaning
			int c = 20;

			// For local variable, use [Noun] or [Adj] + [Noun]
			// Use camelCase for local variable
			string customerAddress = "12 Le Loi";


			int checkExists;  // Not applicable because check verb

			bool isAvailable = true;  // Use it instead
																// Variable must use Noun

			Console.WriteLine($"Age of customer: {customerAge}");
			Console.WriteLine($"Price of iPhone: {iPhonePrice}");

			string outer = "I'm outside the loop";
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine(outer);   // Can access outer inside loop
				string inner = "I'm inside the loop";
				Console.WriteLine(inner);
			}
			Console.WriteLine(outer);
			// Error because inner variable only exists in Loop
			// Console.WriteLine(inner); 

			if (outer.Length == 0)
			{
				string insideIf = "I am inside If statements";
				Console.WriteLine(insideIf);
			}
			// Error because insideIf exists only in If statement
			// Console.WriteLine(insideIf);


			// Integer Operations
			int firstNumber = int.Parse(Console.ReadLine());
			int secondNumber = int.Parse(Console.ReadLine());
			int thirdNumber = int.Parse(Console.ReadLine());
			int fourthNumber = int.Parse(Console.ReadLine());

			int result = ((firstNumber + secondNumber) / thirdNumber) * fourthNumber;

			Console.WriteLine($"Result: {result}");
			Console.ReadLine();
		}
	}
}
