using System;
using System.Collections.Generic;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using OData.DotNetCore.Api.Models;

namespace OData.DotNetCore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        [EnableQuery]
        public IActionResult GetAll()
        {
            var students = CreateStudents();

            return Ok(students);
        }

        private IEnumerable<Student> CreateStudents()
        {
            var school = new School()
            {
                Id = Guid.NewGuid(),
                Name = "My Elementary School",
                City = "Sorocaba",
                State = "São Paulo"
            };

            List<Student> students = new List<Student>()
            {
                new Student() { Id = Guid.NewGuid(), Name = "James Bond", SchoolId = school.Id, School = school},
                new Student() { Id = Guid.NewGuid(), Name = "Jason Bourne", SchoolId = school.Id, School = school},
                new Student() { Id = Guid.NewGuid(), Name = "John Wick", SchoolId = school.Id, School = school}
            };

            return students;
        }
    }
}