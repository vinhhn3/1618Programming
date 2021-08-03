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



			Console.ReadLine();
		}
	}
}
