using CQRS.Commands;
using CQRS.Entities;
using CQRS.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS.Handler.CommandQuery
{
    public class AddSchoolHandler : IRequestHandler<AddSchoolCommand, School>
    {
        public ISchoolRepository _repository { get; }
        public AddSchoolHandler(ISchoolRepository repository)
        {
            _repository = repository;
        }

        public async Task<School> Handle(AddSchoolCommand request, CancellationToken cancellationToken)
        {
            var school = await _repository.SaveSchool(request.School);
            return school;
        }
    }
}
