using System;

namespace GCD0904Polymorphism
{
	class Animal
	{
		public void Eat()
		{
			Console.WriteLine("Animal is eating ...");
		}

		public string Eat(string food)
		{
			string result = $"Animal eats {food}";
			return result;
		}

		public string Eat(string food, string drink)
		{
			string result = $"Animal eats {food} and drink {drink}";
			return result;
		}
	}
}
