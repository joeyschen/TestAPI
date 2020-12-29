using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestAPI.Services;
using TestAPI.Models;
using System.Collections.Generic;

namespace Test_Tests.Students
{

    [TestClass]
    public class GetStudents
    {
        [TestMethod]
        public void GetStudentById()
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
            Student studentTest = studentService.getStudentById(1);
            Assert.AreEqual(student, studentTest, "Did not get correct Student");

        }
    }
}
