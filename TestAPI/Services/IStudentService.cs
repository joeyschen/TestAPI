using System;
using TestAPI.Models;
using System.Collections.Generic;

namespace TestAPI.Services
{
    public interface IStudentService
    {
        Student getStudentById(int id);

        int addStudent(Student student);

        List<Student> getAllStudents();
    }
}
