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
			//int firstNumber = int.Parse(Console.ReadLine());
			//int secondNumber = int.Parse(Console.ReadLine());
			//int thirdNumber = int.Parse(Console.ReadLine());
			//int fourthNumber = int.Parse(Console.ReadLine());

			//int result = ((firstNumber + secondNumber) / thirdNumber) * fourthNumber;

			//Console.WriteLine($"Result: {result}");

			// Real Numbers
			float floatPI = 3.141592653589793238f;
			double doublePI = 3.141592653589793238;
			Console.WriteLine("Float PI is: {0}", floatPI);   // 3.141593
			Console.WriteLine("Double PI is: {0}", doublePI); // 3.14159265358979

			Console.WriteLine(0.1 + 0.2 == 0.3);  // False
			Console.WriteLine(0.1 + 0.2 > 0.3);   // True
																						// Read more: https://genk.vn/khi-chrome-cho-ra-ket-qua-01-02-03-ban-chat-thuc-su-cua-laptop-windows-iphone-va-nhung-co-may-tinh-toan-ban-dang-dung-hang-ngay-20200927165653803.chn

			// Scientific Notation
			double d = 10000000000000000000000000000000000.0;
			Console.WriteLine(d); // 1E+34
			double d2 = 20e-3;
			Console.WriteLine(d2); // 0.02
			double d3 = double.MaxValue;
			Console.WriteLine(d3); // 1.79769313486232E+308

			// Floating-Point Division
			Console.WriteLine(10 / 4);    // (int / int) = int => 2
			Console.WriteLine(10 / 4.0);  // (int / double) = double =. 2.5

			Console.WriteLine(10 / 0.0);  // Infinity
			Console.WriteLine(-10 / 0.0); // -Infinity

			Console.WriteLine(0 / 0.0);   // NaN (not a number)
			Console.WriteLine(8 % 2.5);   // (int % double) = double => 0.5 (3 * 2.5 + 0.5 = 8)

			Console.WriteLine(8 * 2.5);   // (int * double) = double => 20.0

			Console.WriteLine(100000000000000.0 + 0.3); // 100000000000000 (loss of precision)

			double a1 = 1.0f, b1 = 0.33f, sum = 1.33;
			Console.WriteLine("a1+b1={0} sum={1} equal={2}",
				a1 + b1, sum, (a + b == sum));
			// a+b=1.33000001311302 sum=1.33 equal = False

			Console.ReadLine();
		}
	}
}
