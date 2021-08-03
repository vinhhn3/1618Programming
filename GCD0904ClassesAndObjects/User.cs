using System;

namespace GCD0904ClassesAndObjects
{
	class User
	{
		// Properties
		public string FullName;
		public int Age;
		public string Address;
		public int Id;

		// Constructor
		// Constructor without parameters
		// Usage: set default Value
		public User()
		{
			FullName = "Default Name";
			Age = -1;
			Address = "Default Address";
			Id = -1;
		}

		// Constructor with parameters
		public User(string fullName, string address, int age, int id)
		{
			FullName = fullName;
			Address = address;
			Age = age;
			Id = id;
		}


		// Actions
		public void Talk()
		{
			Console.WriteLine("User is talking ...");
		}

		public void Run()
		{
			Console.WriteLine("User is running ...");
		}

		public void Eat()
		{
			Console.WriteLine("User is eating ...");
		}

		public void Sleep()
		{
			Console.WriteLine("User is sleeping ...");
		}

		public void PrintInfo()
		{
			Console.WriteLine("Full Name: " + FullName);
			Console.WriteLine("Age: " + Age);
			Console.WriteLine("Address: " + Address);
			Console.WriteLine("Id: " + Id);
		}

		public void Call(User guest)
		{
			Console.WriteLine("Hello, my name is: " + FullName);
			Console.WriteLine("I am talking to: " + guest.FullName);
		}

		public void Hit(Monster monster)
		{
			Console.WriteLine(FullName + "is hitting " + monster.Name);
			monster.HealthPoints = monster.HealthPoints - 2;
		}
	}
}
