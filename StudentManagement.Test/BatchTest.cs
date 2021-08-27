using NUnit.Framework;

namespace StudentManagement.Test
{
  [TestFixture]
  public class BatchTest
  {

    [Test]
    public void AddStudent_ShouldIncrementStudentListCount_WhenAddStudentSuccesfully()
    {
      // Arrange 
      Batch _batch = new Batch("ABC");
      var student = new Student(1, "Vinh Hoang", "Computing", 19, "GCD0904", 10.0);

      // Act
      _batch.AddStudent(
          student.Id,
          student.FullName,
          student.Major,
          student.Age,
          student.ClassName,
          student.Mark
        );

      // Assert
      var expectedLength = 1;
      Assert.AreEqual(expectedLength, _batch._students.Count);
    }

    [Test]
    public void RemoveStudentById_ShoudlReturnTrue_WhenRemoveStudentSuccesfully()
    {
      // Arrange
      Batch _batch = new Batch("ABC");
      var student = new Student(1, "Vinh Hoang", "Computing", 19, "GCD0904", 10.0);
      _batch.AddStudent(
        student.Id,
        student.FullName,
        student.Major,
        student.Age,
        student.ClassName,
        student.Mark
      );
      // Act
      var result = _batch.RemoveStudentById(1);

      // Assert
      var expected = true;
      Assert.AreEqual(expected, result);
    }

    [Test]
    public void RemoveStudentById_ShouldReturnFalse_WhenStudentDoesNotExist()
    {
      // Arrange
      Batch _batch = new Batch("ABC");
      var student = new Student(1, "Vinh Hoang", "Computing", 19, "GCD0904", 10.0);
      _batch.AddStudent(
        student.Id,
        student.FullName,
        student.Major,
        student.Age,
        student.ClassName,
        student.Mark
      );
      // Act
      var result = _batch.RemoveStudentById(10);

      // Assert
      var expected = false;
      Assert.AreEqual(expected, result);
    }

    [Test]
    public void GetStudentById_ShouldReturnTrue_WhenStudentExists()
    {
      // Arrange
      Batch _batch = new Batch("ABC");
      var student = new Student(1, "Vinh Hoang", "Computing", 19, "GCD0904", 10.0);
      _batch.AddStudent(
        student.Id,
        student.FullName,
        student.Major,
        student.Age,
        student.ClassName,
        student.Mark
      );

      // Act
      var result = _batch.GetStudentById(1);

      // Assert
      Assert.AreEqual(student.Id, result.Id);
    }

    [Test]
    public void GetStudentById_ShouldReturnFalse_WhenStudentDoesNotExists()
    {
      // Arrange
      Batch _batch = new Batch("ABC");
      var student = new Student(1, "Vinh Hoang", "Computing", 19, "GCD0904", 10.0);
      _batch.AddStudent(
        student.Id,
        student.FullName,
        student.Major,
        student.Age,
        student.ClassName,
        student.Mark
      );

      // Act
      var result = _batch.GetStudentById(10);

      // Assert
      Assert.IsNull(result);
    }

    [Test]
    public void UpdateStudentById_ShouldReturnTrue_WhenUpdateSucessfully()
    {
      // Arrange
      Batch _batch = new Batch("ABC");
      var student = new Student(1, "Vinh Hoang", "Computing", 19, "GCD0904", 10.0);
      _batch.AddStudent(
        student.Id,
        student.FullName,
        student.Major,
        student.Age,
        student.ClassName,
        student.Mark
      );

      // Act
      var result = _batch.UpdateStudentById(1, "Vinh Hoang updated",
        "Computing updated", 29, "GCD0904 updated", 90.0);

      // Assert
      var expected = true;
      Assert.AreEqual(expected, result);
    }

    [Test]
    public void UpdateStudentById_ShouldReturnFalse_WhenStudentDoesNotExists()
    {
      // Arrange
      Batch _batch = new Batch("ABC");
      var student = new Student(1, "Vinh Hoang", "Computing", 19, "GCD0904", 10.0);
      _batch.AddStudent(
        student.Id,
        student.FullName,
        student.Major,
        student.Age,
        student.ClassName,
        student.Mark
      );

      // Act
      var result = _batch.UpdateStudentById(10, "Vinh Hoang updated",
        "Computing updated", 29, "GCD0904 updated", 90.0);

      // Assert
      var expected = false;
      Assert.AreEqual(expected, result);
    }
  }
}
