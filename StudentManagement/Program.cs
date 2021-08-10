namespace StudentManagement
{
	class Program
	{
		static void Main(string[] args)
		{
			Batch batch = new Batch("2021 - 2022");
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
							IO.EnterStudentClass()
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
								IO.EnterStudentClass()
								)
							);
						break;
					case MenuOptions.GET_BY_ID:
						IO.ToScreen(batch.GetStudentById(IO.EnterStudentId()));
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
