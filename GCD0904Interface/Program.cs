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

			Circle circle = new Circle(5.0);
			Rectangle rectangle = new Rectangle(3.0, 5.0);

			circle.Draw();
			Console.WriteLine("Circle Area: " + circle.CalculateArea());

			rectangle.Draw();
			Console.WriteLine("Rectangle Area: " + rectangle.CalculateArea());

			IShape shape = new Circle(3.0);
			shape.Draw();
			Console.WriteLine("Area of Shape: " + shape.CalculateArea());

			shape = new Rectangle(5.0, 5.0);
			shape.Draw();
			Console.WriteLine("Area of Shape: " + shape.CalculateArea());

			Console.ReadLine();
		}
	}
}
