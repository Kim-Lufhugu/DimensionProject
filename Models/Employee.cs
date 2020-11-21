using System;

namespace DimensionProject.Models
{
    public class Employee
    {
        public long Id {get; set; }
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public DateTime? DateEmployed {get;set;}
    }
}