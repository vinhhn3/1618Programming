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
	}
}
