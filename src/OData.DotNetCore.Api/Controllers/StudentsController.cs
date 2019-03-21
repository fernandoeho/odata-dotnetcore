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
            var schoolId = Guid.NewGuid();
            List<Student> students = new List<Student>()
            {
                new Student() { Id = Guid.NewGuid(), Name = "James Bond", SchoolId = schoolId},
                new Student() { Id = Guid.NewGuid(), Name = "Jason Bourne", SchoolId = schoolId},
                new Student() { Id = Guid.NewGuid(), Name = "John Wick", SchoolId = schoolId}
            };

            return Ok(students);
        }
    }
}