using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace organisation_x_api.Entities
{
    public class Employee
    {
        public int id { get; set; }

        public string firstname { get; set; }

        public string lastname { get; set; }

        public DateTime? DateEmployed { get; set; }
    }
}
