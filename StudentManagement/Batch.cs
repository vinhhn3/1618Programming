using System.Collections.Generic;

namespace StudentManagement
{
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
