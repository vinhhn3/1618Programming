using System;

namespace GCD0904ClassesAndObjectsExercises
{
	class Student
	{
		public string FirstName;
		public string LastName;
		public string HomeTown;
		public int Age;

		public Student()
		{

		}

		public Student(string firstName, string lastName, int age, string homeTown)
		{
			FirstName = firstName;
			LastName = lastName;
			HomeTown = homeTown;
			Age = age;
		}

		public void PrintInfo()
		{
			Console.WriteLine($"{FirstName} {LastName} is {Age} years old");
		}
	}
}
