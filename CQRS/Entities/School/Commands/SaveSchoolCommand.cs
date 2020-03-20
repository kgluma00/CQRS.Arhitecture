using CQRS.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.Commands
{
    public class SaveSchoolCommand : IRequest<School>
    {
        public SaveSchoolCommand(School school)
        {
            School = school;
        }
        public School School { get; }
    }
}
