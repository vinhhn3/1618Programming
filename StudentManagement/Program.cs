namespace StudentManagement
{
  class Program
  {

    static void Main(string[] args)
    {
      Batch batch = new Batch("2021 - 2022");
      Application app = new Application(batch);
      // Hard code list students
      app.AddStudent(1, "Vinh Hoang", "Computing", 20, "GCD0903", 12);
      app.AddStudent(2, "John Wick", "Computing", 22, "GCD0903", 15.6);
      app.AddStudent(3, "Doe Doe", "Computing", 30, "GCD0903", 12);
      app.AddStudent(4, "John Lennon", "Biz", 18, "GCD0903", 19.9);
      app.AddStudent(5, "George Best", "Computing", 27, "GCD0903", 20.0);
      app.AddStudent(6, "Eric Cantona", "Biz", 25, "GCD0903", 28.0);
      app.AddStudent(7, "Messi", "Biz", 29, "GCD0903", 30);
      app.AddStudent(8, "CR7", "Computing", 33, "GCD0903", 14);
      app.AddStudent(9, "Ronaldo", "Biz", 50, "GCD0903", 20);
      app.AddStudent(10, "Tom Cruise", "Computing", 16, "GCD0903", 22);

      IO.PrintMenu();
      int inputMenu = MenuOptions.INIT;
      while (inputMenu != MenuOptions.EXIT)
      {
        inputMenu = IO.EnterMenuOption();
        switch (inputMenu)
        {
          case MenuOptions.GET_ALL:
            IO.ToScreen(app.GetAllStudentsInfo());
            break;
          case MenuOptions.ADD_STUDENT:
            app.AddStudent(
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
            IO.ShowMessage(app.RemoveStudentById(IO.EnterStudentId()));
            break;
          case MenuOptions.UPDATE_STUDENT:
            IO.ShowMessage(
              app.UpdateStudentById(
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
            IO.ToScreen(app.GetStudentById(IO.EnterStudentId()).ToString());
            break;

          case MenuOptions.STATS:
            IO.ToScreen(app.GetStatistics());
            break;
          // TODO
          case MenuOptions.SEARCH_BY_AGE:
            break;
          case MenuOptions.SEARCH_BY_MARK:
            break;
          case MenuOptions.SEARCH_BY_CLASS_NAME:
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
