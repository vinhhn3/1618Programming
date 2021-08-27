namespace StudentManagement
{
  public class Student
  {
    public int Id;
    public string FullName;
    public string Major;
    public int Age;
    public string ClassName;
    public double Mark;

    private Student() { }
    public Student(int id, string fullName, string major,
      int age, string className, double mark)
    {
      Id = id;
      FullName = fullName;
      Major = major;
      Age = age;
      ClassName = className;
      Mark = mark;
    }

    public override string ToString()
    {
      string result = $"Id: {Id} | Full Name: {FullName} | Age: {Age} | " +
        $"Major: {Major} | Class: {ClassName} | Mark: {Mark}\n";
      return result;
    }
  }
}
