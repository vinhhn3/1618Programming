using System;

namespace GCD0904InheritanceAndEncapsulation
{
	// class User inherits class Person
	class User : Person
	{
		public string Email;
		public string Password;

		public User()
		{

		}

		public User(string fullName, int age,
			string address, string email, string password)
			// base: use constructor of class Person
			// Person(string fullName, int age, string address)
			: base(fullName, age, address)
		{
			Email = email;
			Password = password;
		}

		public void PrintInfo()
		{
			// Call function PrintInfo() of class Person
			base.PrintInfo();
			// Because "_id" in class Person is protected
			// Child classes (Student, User) can access _id directly
			Console.WriteLine($"Email: {Email}, Password: {Password}, Id: {_id}");
		}
	}
}
