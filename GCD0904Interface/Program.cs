﻿using System;

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

			Console.ReadLine();
		}
	}
}
