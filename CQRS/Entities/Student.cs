
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public School School { get; set; }
    }
}
