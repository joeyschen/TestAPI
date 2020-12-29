using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using TestAPI.Models;

namespace TestAPI.Services
{
    public class StudentService : IStudentService
    {
        private Dictionary<int, Student> studentContext = new Dictionary<int, Student>();

        public StudentService()
        {
            
        }

        public int addStudent(Student student)
        {
            studentContext.Add(student.StudentId, student);

            return student.StudentId;
        }

        public Student getStudentById(int id)
        {
            return studentContext[id];
        }

        public List<Student> getAllStudents(){
            return studentContext.Values.ToList();
        }
    }
}
