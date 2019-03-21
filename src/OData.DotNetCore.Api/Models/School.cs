using System;

namespace OData.DotNetCore.Api.Models
{
    public class School
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}