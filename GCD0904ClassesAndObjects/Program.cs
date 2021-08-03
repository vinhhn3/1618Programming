using System;

namespace GCD0904ClassesAndObjects
{
	class Program
	{
		static void Main(string[] args)
		{
			// Delcare an object
			// ClassName variableName = new ClassName();
			User firstUser = new User();

			// Assign values to each property of firstUser object
			firstUser.FullName = "Vinh Hoang";
			firstUser.Age = 30;
			firstUser.Address = "Le Loi";
			firstUser.Id = 123;

			// Read all properties of firstUser
			Console.WriteLine("Full Name: " + firstUser.FullName);
			Console.WriteLine("Age: " + firstUser.Age);
			Console.WriteLine("Address: " + firstUser.Address);
			Console.WriteLine("Id: " + firstUser.Id);

			// Let object use function
			firstUser.Run();
			firstUser.Sleep();

			// Declare a second User object
			User secondUser = new User();

			// Assign value to properties
			secondUser.FullName = "Vinh Tam";
			secondUser.Age = 10;
			secondUser.Address = "Le Lai";
			secondUser.Id = 345;

			// Print info of secondUser
			secondUser.PrintInfo();

			// Declare an User object with Constructor
			User thirdUser = new User();
			thirdUser.PrintInfo();

			// Delcare an User object with parameters
			User fourthUser = new User("John Lennon", "Baker Street", 50, 999);
			fourthUser.PrintInfo();

			// Interaction between objects
			secondUser.Call(fourthUser);

			Monster monster = new Monster();
			monster.PrintInfo();

			secondUser.Hit(monster);
			monster.PrintInfo();

			Console.ReadLine();
		}
	}
}
