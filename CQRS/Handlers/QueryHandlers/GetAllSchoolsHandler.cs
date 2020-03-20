using CQRS.Entities;
using CQRS.Queries;
using CQRS.Repository;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS.Handler
{
    public class GetAllSchoolsHandler : IRequestHandler<GetAllSchoolsQuery, List<School>>
    {
        public ISchoolRepository _repository { get; }
        public ApplicationContext _context { get; set; }

        public GetAllSchoolsHandler(ISchoolRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<School>> Handle(GetAllSchoolsQuery request, CancellationToken cancellationToken)
        {
            return await _context.Schools.ToListAsync();
        }
    }
}
