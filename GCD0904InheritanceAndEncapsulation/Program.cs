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

			Console.ReadLine();
		}
	}
}
