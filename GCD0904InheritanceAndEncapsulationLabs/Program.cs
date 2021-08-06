using System;
using System.Collections.Generic;
using System.Linq;

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

			int lines = int.Parse(Console.ReadLine());  // Enter number of persons
			List<Person> persons = new List<Person>();  // Create list of Person
			for (int i = 0; i < lines; i++)             // Execute loops
			{
				string[] cmdArgs = Console.ReadLine().Split().ToArray();  // Process string
				Person person = new Person(
					cmdArgs[0], // FullName
					cmdArgs[1], // LastName
					int.Parse(cmdArgs[2])); // Age

				persons.Add(person);      // Add new person in to List
			}

			persons.OrderBy(p => p.FirstName) // Order by FirstName
						 .ThenBy(p => p.Age)        // Order by Age
						 .ToList()                  // Convert result => List
						 .ForEach(p => Console.WriteLine(p.ToString()));
			// foreach item in List, print info

			Console.ReadLine();
		}

	}
}

