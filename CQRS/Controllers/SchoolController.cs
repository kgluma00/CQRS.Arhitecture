using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRS.Entities;
using CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SchoolController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSchools()
        {
            var query = new GetAllSchoolsQuery();
            var response = await _mediator.Send(query);

            return Ok(response);
        }

        [HttpGet]
        [Route("{schoolId}")]
        public async Task<IActionResult> GetSchoolById(int schoolId)
        {
            var query = new GetSchoolByIdQuery(schoolId);
            var response = await _mediator.Send(query);

            return Ok(response);
        }
    }
}