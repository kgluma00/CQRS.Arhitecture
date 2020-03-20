using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.Entities
{
    public class School
    {
        public int Id { get; set; }
        public string SchoolName { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
