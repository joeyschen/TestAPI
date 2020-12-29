using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestAPI.Services;
using TestAPI.Models;
using System.Collections.Generic;

namespace Test_Tests.Students
{

    [TestClass]
    public class AddStudent
    {
        [TestMethod]
        public void AddingStudentIntoDB()
        {
            //Arrange
            Student student = new Student()
            {
                StudentId = 1,
                FirstName = "Joey",
                LastName = "Chen",
                Address = "1234 Maple St"
            };

            IStudentService studentService = new StudentService();

            //Act
            studentService.addStudent(student);

            //Assert
            List<Student> studentList = studentService.getAllStudents();
            Assert.AreEqual(1, studentList.Count, "Did not add customer");

        }
    }
}
