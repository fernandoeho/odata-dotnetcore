using System;

namespace OData.DotNetCore.Api.Models
{
    public class School
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}