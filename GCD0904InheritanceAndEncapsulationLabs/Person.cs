namespace GCD0904InheritanceAndEncapsulationLabs
{
	class Person
	{
		public string FirstName;
		public string LastName;
		public int Age;

		public Person()
		{

		}

		public Person(string firstName, string lastName, int age)
		{
			FirstName = firstName;
			LastName = lastName;
			Age = age;
		}

		public override string ToString()
		{
			string result = $"{FirstName} {LastName} is {Age} years old";
			return result;
		}
	}
}
