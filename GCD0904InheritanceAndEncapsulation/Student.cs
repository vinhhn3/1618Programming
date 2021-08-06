using System;

namespace GCD0904InheritanceAndEncapsulation
{
	class Student : Person
	{
		public string Major;
		public string ClassName;

		public Student()
		{

		}

		public Student(string fullName, int age, string address,
			string major, string className)
			: base(fullName, age, address)
		{
			Major = major;
			ClassName = className;
		}

		public void PrintInfo()
		{
			base.PrintInfo();
			Console.WriteLine($"Major: {Major}, Class Name: {ClassName}");
		}
	}
}
