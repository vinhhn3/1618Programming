namespace StudentManagement
{
  public interface IBatch
  {
    string GetAllStudentsInfo();
    Student GetStudentById(int id);
    bool RemoveStudentById(int id);
    bool UpdateStudentById(int id, string fullName, string major,
      int age, string className, double mark);
    void AddStudent(int id, string fullName, string major,
      int age, string className, double mark);
    string GetStatistics();

  }
}
