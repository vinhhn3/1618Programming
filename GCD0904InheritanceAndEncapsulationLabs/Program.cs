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

			puppy.Eat();    // function from class Animal
			puppy.Bark();   // function from class Dog
			puppy.Weep();   // function from class Puppy

			cat.Eat();      // function from class Animal
			cat.Meow();     // function form class Cat


			Console.ReadLine();

			int lines = int.Parse(Console.ReadLine());  // Enter number of persons
			List<Person> persons = new List<Person>();  // Create list of Person
			for (int i = 0; i < lines; i++)             // Execute loops
			{
				string[] cmdArgs = Console.ReadLine().Split().ToArray();  // Process string
				Person person = new Person(
					cmdArgs[0], // FullName
					cmdArgs[1], // LastName
					int.Parse(cmdArgs[2]),    // Age
					decimal.Parse(cmdArgs[3]) // Salary
					);


				persons.Add(person);      // Add new person in to List
			}


			// Order
			persons.OrderBy(p => p.FirstName) // Order by FirstName
						 .ThenBy(p => p.Age)        // Order by Age
						 .ToList()                  // Convert result => List
						 .ForEach(p => Console.WriteLine(p.ToString()));
			// foreach item in List, print info

			// Increase Salary for each person 50%
			persons.ForEach(p => p.IncreaseSalary(50));

			// Display all persons to screen
			persons.ForEach(p => Console.WriteLine(p.ToString()));

			Console.ReadLine();
		}

	}
}

