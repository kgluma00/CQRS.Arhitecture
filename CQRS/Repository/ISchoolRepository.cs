using CQRS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.Repository
{
    public interface ISchoolRepository
    {
        Task<List<School>> GetAllSchools();
        Task<School> GetSchoolById(int schoolId);
    }
}
