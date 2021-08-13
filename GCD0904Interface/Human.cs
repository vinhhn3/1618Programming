using System;

namespace GCD0904Interface
{
	class Human : IBeing
	{
		public int Age;
		public string FullName;

		public Human()
		{

		}

		public Human(int age, string fullName)
		{
			Age = age;
			FullName = fullName;
		}

		public void Eat()
		{
			Console.WriteLine("Human is eating ...");
		}

		public void Run()
		{
			Console.WriteLine("Human is running ...");
		}

		public void Sleep()
		{
			Console.WriteLine("Human is sleeping ...");
		}
	}
}
