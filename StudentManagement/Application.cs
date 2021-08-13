namespace StudentManagement
{
	class Application
	{
		private IBatch _batch;
		public Application(IBatch batch)
		{
			_batch = batch;
		}
		public bool UpdateStudentById(int id, string fullName, string major,
			int age, string className, double mark)
		{
			return _batch.UpdateStudentById(id, fullName, major, age, className, mark);
		}
		public string GetAllStudentsInfo()
		{
			return _batch.GetAllStudentsInfo();
		}

		public string GetStudentById(int id)
		{
			return _batch.GetStudentById(id);
		}
		public bool RemoveStudentById(int id)
		{
			return _batch.RemoveStudentById(id);
		}

		public void AddStudent(int id, string fullName, string major,
			int age, string className, double mark)
		{
			_batch.AddStudent(id, fullName, major, age, className, mark);
		}
		public string GetStatistics()
		{
			return _batch.GetStatistics();
		}
	}
}
