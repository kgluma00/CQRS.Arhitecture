using CQRS.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.Queries
{
    public class GetAllSchoolsQuery : IRequest<List<School>>
    {
        public int SchoolId { get; set; }
    }
}
