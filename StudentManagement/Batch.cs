using System.Collections.Generic;
using System.Linq;

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

		public string GetStudentById(int id)
		{
			Student studentInBatch = _students.FirstOrDefault(std => std.Id.Equals(id)); // LINQ
			if (studentInBatch == null)
			{
				return "Not Exists";
			}
			return studentInBatch.ToString();
		}

		public bool RemoveStudentById(int id)
		{
			Student studentInBatch = _students.FirstOrDefault(s => s.Id.Equals(id));
			if (studentInBatch != null)
			{
				_students.Remove(studentInBatch);
				return true;
			}
			return false;
		}

		public bool UpdateStudentById(int id, string fullName, string major, int age, string className)
		{
			Student studentInBatch = _students.FirstOrDefault(s => s.Id.Equals(id));
			if (studentInBatch == null) return false;
			studentInBatch.FullName = fullName;
			studentInBatch.Major = major;
			studentInBatch.Age = age;
			studentInBatch.ClassName = className;
			return true;
		}
		public void AddStudent(int id, string fullName, string major, int age, string className)
		{
			Student newStudent = new Student(id, fullName, major, age, className);
			_students.Add(newStudent);
		}

	}
}
