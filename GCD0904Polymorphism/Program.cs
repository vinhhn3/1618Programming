using System;

namespace GCD0904Polymorphism
{
	class Program
	{
		static void Main(string[] args)
		{
			// Overloading methods
			// Same function name but behave differently
			Animal animal = new Animal();
			animal.Eat(); // void

			Console.WriteLine(animal.Eat("meat")); // return string

			Console.WriteLine(animal.Eat("meat", "water")); // string

			Console.ReadLine();
		}
	}
}
