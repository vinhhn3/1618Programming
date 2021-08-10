using System;

namespace StudentManagement
{
	// Display information to Screen
	// Receive input from keyboard
	class IO
	{
		public static void PrintMenu()
		{
			Console.WriteLine("========MENU==========");
			Console.WriteLine("WELCOME TO THE APP");

		}

		public static int EnterMenuOption()
		{
			Console.WriteLine("Menu Options: ");
			Console.WriteLine("1. Print all students info");
			Console.WriteLine("2. Add a new Student");
			Console.WriteLine("3. Remove Student by ID");
			Console.WriteLine("4. Update Student by ID");
			Console.WriteLine("5. Print Student info by ID");
			Console.WriteLine("6. Exit Application");
			return int.Parse(Console.ReadLine());
		}

		public static string EnterStringValue()
		{
			return Console.ReadLine();
		}

		public static int EnterStudentId()
		{
			Console.Write("Id: ");
			return int.Parse(Console.ReadLine());
		}

		public static int EnterStudentAge()
		{
			Console.Write("Age: ");
			return int.Parse(Console.ReadLine());
		}

		public static string EnterStudentName()
		{
			Console.Write("Name: ");
			return Console.ReadLine();
		}

		public static string EnterStudentMajor()
		{
			Console.Write("Major: ");
			return Console.ReadLine();
		}

		public static string EnterStudentClass()
		{
			Console.Write("Class: ");
			return Console.ReadLine();
		}

		public static int EnterIntValue()
		{
			return int.Parse(Console.ReadLine());
		}

		public static void ToScreen(string str)
		{
			Console.WriteLine(str);
		}

		public static void InputError()
		{
			Console.WriteLine("Invalid Input ...");
		}
	}
}
