using System;

namespace GCD0904Interface
{
	class Animal : IBeing, IRunnable
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
		// Functions implemented for interface IBeing
		public void Born()
		{
			Console.WriteLine("Animal is born ...");
		}

		public void Die()
		{
			Console.WriteLine("Animal is dying ...");
		}

		public void Drink()
		{
			Console.WriteLine("Animal is drinking ...");
		}

		public void Eat()
		{
			Console.WriteLine("Animal is eating ...");
		}
		public void Sleep()
		{
			Console.WriteLine("Animal is sleeping ...");
		}
		// Functions implemented for interface IRunnable
		public void Stay()
		{
			Console.WriteLine("Animal is staying ...");
		}
		public void Walk()
		{
			Console.WriteLine("Animal is walking ...");
		}
		public void Run()
		{
			Console.WriteLine("Animal is running ...");
		}

	}
}
