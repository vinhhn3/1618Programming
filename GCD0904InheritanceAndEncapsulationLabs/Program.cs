using System;

namespace GCD0904InheritanceAndEncapsulationLabs
{
	class Program
	{
		static void Main(string[] args)
		{
			Dog dog = new Dog();
			Puppy puppy = new Puppy();
			Cat cat = new Cat();
			dog.Bark();
			dog.Bark();
			dog.Eat();

			puppy.Eat();    // class Animal
			puppy.Bark();   // class Dog
			puppy.Weep();   // class Puppy

			cat.Eat();      // class Animal
			cat.Meow();     // class Cat


			Console.ReadLine();
		}

	}
}

