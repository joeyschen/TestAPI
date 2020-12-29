using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using TestAPI.Models;
using TestAPI.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        private IStudentService _studentService;

        public TestController(IStudentService studentService)
        {
            this._studentService = studentService;
        }

        // GET: /<controller>/

        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id)
        {
            var student = _studentService.getStudentById(id);

            if(student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        [HttpGet]
        public IActionResult GetAllStudents()
        {
            var studentList = _studentService.getAllStudents();

            return Ok(studentList);
        }

        [HttpPost]
        public IActionResult AddStudent([FromBody] Student student )
        {
            Console.WriteLine("I hit the post endpoint");
            if(student == null)
            {
                return BadRequest();
            }

            _studentService.addStudent(student);

            return CreatedAtAction("addStudent", student);
        }
    }
}
