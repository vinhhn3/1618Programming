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

			// Type Conversion
			float height = 1.76f;       // Real Number
			double maxHeight = height;  // Real Number | Implicit Conversion

			double width = 9.88378;         // Real Number - double 64 bit
			float maxWidth = (float)width;  // Real Number - float 32 bit | Explicit Conversion

			int widthInt = (int)width;           // int 32 bit, double 64 bit | Explicit Conversion

			// Problem Elevator
			int people = int.Parse(Console.ReadLine());
			int capacity = int.Parse(Console.ReadLine());

			double result = (double)people / capacity;

			int courses = (int)Math.Ceiling(result);

			Console.WriteLine($"Number of courses needed: {courses}");

			// Centuries to minutes
			int centeries = int.Parse(Console.ReadLine());

			Console.WriteLine($"{centeries} centuries," +
				$" {centeries * 100} years, {centeries * 100 * 365.2442} days," +
				$"{centeries * 100 * 365.2442 * 24} hours," +
				$"{centeries * 100 * 365.2442 * 24 * 60} minutes");

			// Boolean Type
			// Boolean value: True, False
			int numberC = 20;
			int numberD = 30;
			bool isCGreaterThanD = numberC > numberD;
			Console.WriteLine(isCGreaterThanD); // false
			bool isDGreaterThanC = numberD > numberC;
			Console.WriteLine(isDGreaterThanC); // true

			// Special Numbers
			int n = int.Parse(Console.ReadLine());
			for (int num = 1; num <= n; num++)
			{
				int sumOfDigits = 0;
				int digits = num;
				while (digits > 0)
				{
					sumOfDigits += digits % 10;
					digits = digits / 10;
				}
				if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
				{
					Console.WriteLine($"{num}: is Special");
				}
				else
				{
					Console.WriteLine($"{num}: is NOT Special");
				}
			}

			// Character Data Type
			// ASCII Table: https://www.asciitable.com/

			char ch = 'a'; // character '', not ""
			Console.WriteLine(ch);      // 'a'
			Console.WriteLine((int)ch); // 97

			int charInt = 97;
			Console.WriteLine((char)charInt);   // a
			charInt++;
			Console.WriteLine(charInt);         // 98	
			Console.WriteLine((char)charInt);   // b

			char tab = '\t';
			char endOfTheLine = '\n';

			Console.WriteLine("This is a tab: " + '\t' + tab + "End of a Tab");
			Console.WriteLine("This is end of the Line " + '\n' + endOfTheLine + "This is another Line");

			Console.WriteLine('\u0110');
			Console.WriteLine('\u004B');

			// String
			string hello = "Hello World !!!";
			Console.WriteLine(hello);

			Console.WriteLine(hello + "C# is beautiful !!!");

			string path = "D:\\1618Programming";
			path = @"D:\1618Programming";
			string fileName = "Unit1.pdf";

			string filePath = $"{path}\\{fileName}";
			filePath = $@"{path}\{fileName}";
			Console.WriteLine(path);

			Console.WriteLine(filePath);

			// Concat Names
			string firstName = Console.ReadLine();
			string lastName = Console.ReadLine();
			string delimiter = Console.ReadLine();

			string concatNames = $"{firstName} {delimiter} {lastName}";
			concatNames = firstName + " " + delimiter + " " + lastName;

			Console.WriteLine(concatNames);
			Console.WriteLine("{0} {1} {2}", firstName, delimiter, lastName);

			Console.ReadLine();
		}
	}
}
