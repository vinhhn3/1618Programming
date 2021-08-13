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

			// Overrding methods
			// Parent class and Child class have the same function but it behave differently
			Dog dog = new Dog();
			dog.Eat();
			Console.WriteLine(dog.Eat("meat"));
			Console.WriteLine(dog.Eat("meat", "coca-cola"));

			// Math Operations exercise
			// Use overloading methods
			MathOperations math = new MathOperations();
			Console.WriteLine(math.Add(10, 20));

			Console.WriteLine(math.Add(123.012, 222.345));

			Console.WriteLine(math.Add(1, 2, 3));

			Console.ReadLine();
		}
	}
}
