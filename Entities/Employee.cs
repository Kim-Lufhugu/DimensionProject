using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace organisation_x_api.Entities
{
    public class Employee
    {
        public int Id { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public DateTime? DateEmployed { get; set; }
    }
}
