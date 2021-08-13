using System;

namespace GCD0904Interface
{
	class Program
	{
		static void Main(string[] args)
		{
			Animal animal = new Animal();
			Human human = new Human();

			animal.Run();
			animal.Eat();

			human.Drink();
			human.Sleep();

			animal.Walk();
			animal.Stay();

			// Return object Animal
			IBeing myAnimal = BeingFactory.GetBeing("Animal");
			myAnimal.Die();
			myAnimal.Eat();
			myAnimal.Born();
			myAnimal.Drink();

			// Can't Run because interface IBeing do not contains Run()
			// myAnimal.Run(); 


			Console.ReadLine();
		}
	}
}
