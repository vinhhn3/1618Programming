using System.Collections.Generic;

namespace StudentManagement
{
	class MenuOptions
	{
		public const int INIT = 0;
		public const int GET_ALL = 1;
		public const int ADD_STUDENT = 2;
		public const int REMOVE_STUDENT = 3;
		public const int UPDATE_STUDENT = 4;
		public const int GET_BY_ID = 5;
		public const int EXIT = 6;
	}
	class Batch
	{
		private List<Student> _students;
		public string Name;

		private Batch() { }

		public Batch(string name)
		{
			Name = name;
			_students = new List<Student>();
		}

		public string GetAllStudentsInfo()
		{
			string result = "";
			foreach (var s in _students)
			{
				result = result + s.ToString();
			}
			return result;
		}

		public void AddStudent(int id, string fullName, string major, int age, string className)
		{
			Student newStudent = new Student(id, fullName, major, age, className);
			_students.Add(newStudent);
		}

	}
}
