namespace GCD0904InheritanceAndEncapsulation
{
	// class User inherits class Person
	class User : Person
	{
		public string Email;
		public string Password;

		public User()
		{

		}

		public User(string fullName, int age,
			string address, string email, string password)
		{

			FullName = fullName;
			Age = age;
			Address = address;
			Email = email;
			Password = password;
		}
	}
}
