using System;

namespace GCD0904NamingConvention
{
	// Class name: PascalCase
	// E.g: StudentManagement, FoodFactory
	// Noun
	public class Student
	{
		// Structor of Class: Properties => Constructors => Methods

		// Properties
		// Property: PascalCase
		// Noun
		// Name: meaningful + English
		public string FullName;
		public int Age;
		public DateTime DateOnboarding;
		public DateTime DateGraduation;
		public DateTime DateOfBirth;

		// private property: _camelCase 
		private string _fullName;
		private int _age;

		// Constructors
		public Student()
		{

		}

		// Parameter of function: camelCase
		public Student(string fullName, int age)
		{
			FullName = fullName;
			Age = age;
		}

		// Methods
		// Method name: Verb + Noun, PascalCase
		public int GetAge()
		{
			return Age;
		}

		public void SetFullName(string fullName)
		{
			FullName = fullName;
		}

		// Do use prefix Any, Is, Have or similar keywords for boolean identifier
		public bool IsOver18()
		{
			return Age > 18;
		}

		public void DoHomeWork(string homeWork, string lab)
		{
			Console.WriteLine($"Studnet is doing {homeWork} and {lab}");
		}
	}
}
