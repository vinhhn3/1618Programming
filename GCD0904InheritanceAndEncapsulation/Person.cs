using System;

namespace GCD0904InheritanceAndEncapsulation
{
	class Person
	{
		public string FullName;
		public int Age;
		public string Address;

		public Person()
		{

		}

		public Person(string fullName, int age, string address)
		{
			FullName = fullName;
			Age = age;
			Address = address;
		}

		public void PrintInfo()
		{
			Console.WriteLine($"Full Name: {FullName}, Age: {Age}, Address: {Address} ");
		}

		public void GetAge()
		{
			Console.WriteLine("My age is: " + Age);
		}
	}
}
