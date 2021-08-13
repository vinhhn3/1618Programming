using System;

namespace GCD0904Interface
{
	class Animal : IBeing
	{
		public int Age;
		public string Location;

		public Animal()
		{

		}

		public Animal(int age, string location)
		{
			Age = age;
			Location = location;
		}

		public void Eat()
		{
			Console.WriteLine("Animal is eating ...");
		}

		public void Run()
		{
			Console.WriteLine("Animal is running ...");
		}

		public void Sleep()
		{
			Console.WriteLine("Animal is sleeping ...");
		}
	}
}
