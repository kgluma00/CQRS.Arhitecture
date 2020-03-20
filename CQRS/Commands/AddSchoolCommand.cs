using CQRS.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.Commands
{
    public class AddSchoolCommand : IRequest<School>
    {
        public AddSchoolCommand(School school)
        {
            School = school;
        }
        public School School { get; }
    }
}
