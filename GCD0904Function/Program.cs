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
		//	doSomething(); => Process
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

		// Overloading methods
		// Same Function Name

		// => Process differently based parameters
		static void PrintHello(string fullName)
		{
			Console.WriteLine("Hello " + fullName);
			Console.WriteLine("Welcome to CSharp ...");
		}

		// => Return different data type
		static string PrintHello(string fullName, int age)
		{
			return $"Hello {fullName}, you are {age} years old ...";
		}

		// error
		// cannot have the same function name with same parameters 
		// but return different data type
		//static void PrintHello(string fullName, int age)
		//{
		//	Console.WriteLine("Vinh Hoang");
		//}

		// => based order of parameters
		static void PrintHello(int age, string fullName)
		{
			Console.WriteLine($"Hello {fullName}, you are {age} years old");
		}

		// ********************************************************************	//
		// 														RECAP																			//
		// ********************************************************************	//					
		// - Declare function
		//	+ DataType return
		//	+ Parameters
		//	+	Body / Process of function
		// - Use function
		//	+ Call in main()
		// 	+ Call in another function
		// - void type method
		// 	+ Do not return any value
		// - "return" keyword
		// 	+ create new value
		// 	+ stop method's execution immediately 
		// - Overloading Methods
		//	+ Same name but process differently
		//	+ based type of parameters
		//	+ based order of parameters
		// - Stack and Heap (to be continued ...)
		// - How to name a function

		static void IncreaseNumber(int a)
		{
			Console.WriteLine("Begin function IncreaseNumber");
			a = a + 1;
			Console.WriteLine(a);
			Console.WriteLine("End function IncreaseNumber");
		}

		//	Naming and best practices
		//	Function:
		//		- Meaningful 
		//		- PascalCase: RemoveById, UpdateStudentById
		//		- [Verb] + [Noun]: SumTwoNumbers, FindStudent, FindHighestMark
		//		- English, no Vietnamese
		//		- camelCase for params: firstName, lastName, userList, 
		//	Code can documents itself => Code Clean
		//	Clean Code - Uncle Bob


		static void PrintHeader()
		{
			Console.WriteLine("This is Header");
		}

		static void PrintBody()
		{
			Console.WriteLine("This is Body");
		}

		static void PrintFooter()
		{
			Console.WriteLine("This is Footer");
		}

		static void PrintReceipt()
		{
			PrintHeader();
			PrintBody();
			PrintFooter();
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

			PrintHello();               // void
			PrintHello("Vinh Hoang");   // void
			string hello = PrintHello("Vinh Hoang", 300); // string
			Console.WriteLine(hello);

			PrintHello(300, "Vinh Hoang");

			numberA = 100; // Primitive data => declare Stack
			Console.WriteLine("Value of numberA: " + numberA);
			IncreaseNumber(numberA); // Function run Heap
			Console.WriteLine("Value of numberA: " + numberA);

			Console.WriteLine("=== Increase Array ===");

			int[] arr = new int[]
			{
				1
			};

			Console.WriteLine(arr[0]);    // 1 Declare arr => Heap
			IncreaseNumber(arr);          // 2 Function run heap
			Console.WriteLine(arr[0]);    // 2 
			Console.ReadLine();
		}
		static void IncreaseNumber(int[] a)
		{
			a[0] = a[0] + 1;
			Console.WriteLine("Value inside function: " + a[0]);
		}

	}
}
