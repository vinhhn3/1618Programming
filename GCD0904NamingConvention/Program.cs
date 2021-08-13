using System;
using System.Collections.Generic;

namespace GCD0904NamingConvention
{
	class Program
	{
		static void Main(string[] args)
		{
			// Variable in Main: camelCase
			Student student = new Student();
			Student myStudent = new Student("Vinh Hoang", 30);

			// Do not use Underscores in identifiers.
			// Exception: you can prefix private fields with an underscore:
			// Avoid
			Student your_student = new Student();
			DateTime date_of_birth = new DateTime();

			// Correct
			Student yourStudent = new Student();
			DateTime dateOfBirth = new DateTime();

			if (myStudent.IsOver18())
			{
				Console.WriteLine("College Student");
			}
			else
			{
				Console.WriteLine("High School Student");
			}

			// Use Named Arguments in method calls
			myStudent.DoHomeWork(homeWork: "Slide1", lab: "Labs2");

			// Do use implicit type var for local variable declarations
			List<Student> students = new List<Student>();
			var myStudents = new List<Student>();
		}
	}
}
