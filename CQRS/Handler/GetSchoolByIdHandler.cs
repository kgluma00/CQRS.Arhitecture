using CQRS.Entities;
using CQRS.Queries;
using CQRS.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS.Handler
{
    public class GetSchoolByIdHandler : IRequestHandler<GetSchoolByIdQuery, School>
    {
        public ISchoolRepository _repository { get; }
        public GetSchoolByIdHandler(ISchoolRepository repository)
        {
            _repository = repository;
        }
        public async Task<School> Handle(GetSchoolByIdQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetSchoolById(request.SchoolId);
        }
    }
}
