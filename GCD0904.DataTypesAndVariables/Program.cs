﻿using System;

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

			int CustomerAge = 20;
			int Customer_Age = 20;
			int customer_Age = 20;
			int CUSTOMER_AGE = 20;

			// Variable must use Noun
			int checkExists;  // Not applicable because check verb

			bool isAvailable = true;  // Use it instead

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



			Console.ReadLine();
		}
	}
}
