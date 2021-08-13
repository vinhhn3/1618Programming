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
		public const int STATS = 6;
		// TODO
		public const int SEARCH_BY_CLASS_NAME = 7;
		public const int SEARCH_BY_AGE = 8;
		public const int SEARCH_BY_MARK = 9;
		public const int EXIT = 10;
	}
	class Batch : IBatch
	{
		public List<Student> _students;
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

		public bool UpdateStudentById(int id, string fullName, string major,
			int age, string className, double mark)
		{
			Student studentInBatch = _students.FirstOrDefault(s => s.Id.Equals(id));
			if (studentInBatch == null) return false;
			studentInBatch.FullName = fullName;
			studentInBatch.Major = major;
			studentInBatch.Age = age;
			studentInBatch.ClassName = className;
			studentInBatch.Mark = mark;
			return true;
		}
		public void AddStudent(int id, string fullName, string major,
			int age, string className, double mark)
		{
			Student newStudent = new Student(id, fullName, major, age, className, mark);
			_students.Add(newStudent);
		}
		public string GetStatistics()
		{
			string result = "";
			int studentNumber = _students.Count;
			double avgAge = _students.Average(s => s.Age);
			double avgMark = _students.Average(s => s.Mark);
			double highestMark = _students.Max(s => s.Mark);
			double lowestMark = _students.Min(s => s.Mark);
			result =
				$"Number of students: {studentNumber} \n" +
				$"Average age: {avgAge}\n" +
				$"Average mark: {avgMark}\n" +
				$"Highest Mark: {highestMark}\n" +
				$"Lowest Mark: {lowestMark}\n";

			return result;
		}



	}
}
