using System;
using System.Collections.Generic; // Add this using directive
using Microsoft.AspNetCore.Mvc;
using WebAPI_Demo1.Models; // Ensure this matches the namespace of your Student class

namespace WebAPI_Demo1.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        // public List<Student> studlist { get; set; }
        private readonly AppDbContext _context;

        public StudentController( AppDbContext context)
        {
            _context=context;
            // studlist = new List<Student>()
            // {
            //     new Student() { Id = 101, Name = "prathmesh" },
            //     new Student() { Id = 102, Name = "akshay" },
            //     new Student() { Id = 103, Name = "prachiti" },
            //     new Student() { Id = 104, Name = "atharv" },
            //     new Student() { Id = 105, Name = "Yuvaraj" },
            //     new Student() { Id = 106, Name = "pj" },
            //     new Student() { Id = 107, Name = "prabhav" }
            // };
        }

        [HttpGet]
        public IActionResult GetAllStudent()
        {
            var studlist=_context.students.ToList();
           
            return Ok(studlist);
        }
    }
}