using System;

namespace OData.DotNetCore.Api.Models
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid SchoolId { get; set; }
        public School School { get; set; }
    }
}