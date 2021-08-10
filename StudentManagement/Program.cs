namespace StudentManagement
{
	class Program
	{
		static void Main(string[] args)
		{
			Batch batch = new Batch("2021 - 2022");
			IO.PrintMenu();
			int inputMenu = 0;
			while (inputMenu != 9)
			{
				inputMenu = IO.EnterMenuOption();
				switch (inputMenu)
				{
					// 1. Print all Students info
					case 1:
						IO.ToScreen(batch.GetAllStudentsInfo());
						break;
					// 2. Add a new Student
					case 2:
						int id = IO.EnterStudentId();
						string fullName = IO.EnterStudentName();
						string major = IO.EnterStudentMajor();
						int age = IO.EnterStudentAge();
						string className = IO.EnterStudentClass();

						batch.AddStudent(id, fullName, major, age, className);
						break;
					//Exit
					case 9:
						return;
					default:
						break;
				}
			}
		}
	}
}
