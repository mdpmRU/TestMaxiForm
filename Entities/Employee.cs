using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Employee : BaseEntity
    {
        public string LastName { get; set; }

        public string Email { get; set; }

        public DateOnly DateOfBirth { get; set; }

        public Department Department { get; set; }

        public Position Position { get; set; }
    }
}
