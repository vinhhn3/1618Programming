namespace StudentManagement
{
	class Student
	{
		public int Id;
		public string FullName;
		public string Major;
		public int Age;
		public string ClassName;

		private Student() { }
		public Student(int id, string fullName, string major, int age, string className)
		{
			Id = id;
			FullName = fullName;
			Major = major;
			Age = age;
			ClassName = className;
		}

		public override string ToString()
		{
			string result = $"Id: {Id}, Full Name: {FullName}, Age: {Age} " +
				$"Major: {Major} - Class: {ClassName}\n";
			return result;
		}
	}
}
