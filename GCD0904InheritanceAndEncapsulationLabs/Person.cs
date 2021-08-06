namespace GCD0904InheritanceAndEncapsulationLabs
{
	class Person
	{
		public string FirstName;
		public string LastName;
		public int Age;
		public decimal Salary;

		public Person()
		{

		}

		public Person(string firstName, string lastName, int age, decimal salary)
		{
			FirstName = firstName;
			LastName = lastName;
			Age = age;
			Salary = salary;
		}

		public override string ToString()
		{
			string result = $"{FirstName} {LastName} is {Age} years old. Salary is {Salary}";
			return result;
		}

		public void IncreaseSalary(decimal percentage)
		{
			if (Age < 30)
			{
				Salary = Salary + Salary * percentage / 200;
			}
			else
			{
				Salary = Salary + Salary * percentage / 100;
			}
		}
	}
}
