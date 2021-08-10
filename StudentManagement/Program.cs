namespace StudentManagement
{
	class Program
	{
		static void Main(string[] args)
		{
			Batch batch = new Batch("2021 - 2022");
			// Hard code list students
			batch.AddStudent(1, "Vinh Hoang", "Computing", 20, "GCD0903", 12);
			batch.AddStudent(2, "John Wick", "Computing", 22, "GCD0903", 15.6);
			batch.AddStudent(3, "Doe Doe", "Computing", 30, "GCD0903", 12);
			batch.AddStudent(4, "John Lennon", "Biz", 18, "GCD0903", 19.9);
			batch.AddStudent(5, "George Best", "Computing", 27, "GCD0903", 20.0);
			batch.AddStudent(6, "Eric Cantona", "Biz", 25, "GCD0903", 28.0);
			batch.AddStudent(7, "Messi", "Biz", 29, "GCD0903", 30);
			batch.AddStudent(8, "CR7", "Computing", 33, "GCD0903", 14);
			batch.AddStudent(9, "Ronaldo", "Biz", 50, "GCD0903", 20);
			batch.AddStudent(10, "Tom Cruise", "Computing", 16, "GCD0903", 22);

			IO.PrintMenu();
			int inputMenu = MenuOptions.INIT;
			while (inputMenu != MenuOptions.EXIT)
			{
				inputMenu = IO.EnterMenuOption();
				switch (inputMenu)
				{
					case MenuOptions.GET_ALL:
						IO.ToScreen(batch.GetAllStudentsInfo());
						break;
					case MenuOptions.ADD_STUDENT:
						batch.AddStudent(
							IO.EnterStudentId(),
							IO.EnterStudentName(),
							IO.EnterStudentMajor(),
							IO.EnterStudentAge(),
							IO.EnterStudentClass(),
							IO.EnterStudentMark()
							);
						IO.ShowMessage(true);
						break;
					case MenuOptions.REMOVE_STUDENT:
						IO.ShowMessage(batch.RemoveStudentById(IO.EnterStudentId()));
						break;
					case MenuOptions.UPDATE_STUDENT:
						IO.ShowMessage(
							batch.UpdateStudentById(
								IO.EnterStudentId(),
								IO.EnterStudentName(),
								IO.EnterStudentMajor(),
								IO.EnterStudentAge(),
								IO.EnterStudentClass(),
								IO.EnterStudentMark()
								)
							);
						break;
					case MenuOptions.GET_BY_ID:
						IO.ToScreen(batch.GetStudentById(IO.EnterStudentId()));
						break;

					case MenuOptions.STATS:
						IO.ToScreen(batch.GetStatistics());
						break;
					case MenuOptions.EXIT:
						return;
					default:
						IO.InputError();
						break;
				}
			}
		}
	}
}
