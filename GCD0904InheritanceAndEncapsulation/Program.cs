using System;

namespace GCD0904InheritanceAndEncapsulation
{
	class Program
	{
		static void Main(string[] args)
		{
			Person person = new Person("Vinh Hoang", 30, "Le Loi");

			User user = new User("John Wick", 55, "Baker", "john@gmail.com", "12345");

			Console.WriteLine(person.FullName + " " + person.Address + " " + person.Age);

			Console.WriteLine(user.FullName + " " + user.Address + " " + user.Age
				+ " " + user.Password + " " + user.Email);

			Console.WriteLine("=========");
			person.PrintInfo();
			user.PrintInfo();

			person.GetAge();
			user.GetAge();

			// Encapsulation
			person.Age = 10;
			person.Address = "ABC";

			// due to _money, MultipleMoney() are private so in class Program,
			// it can't access property  "_money", function MultipleMoney() directly via "."
			// person._money = 1000;
			// person.MultipleMoney();

			// To access property _moeny, use functions instead
			person.SetMoney(12345);
			Console.WriteLine(person.GetMoney());

			// Due to _id is protected, class Program can't access property "_id"
			// person._id = 10;

			Student student = new Student("John Doe", 123, "Baker", "Computing", "GCD0904");
			student.PrintInfo();

			Console.ReadLine();
		}
	}
}
