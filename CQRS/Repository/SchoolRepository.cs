using CQRS.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.Repository
{
    public class SchoolRepository : ISchoolRepository
    {
        private readonly ApplicationContext _context;

        public SchoolRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<List<School>> GetAllSchools()
        {
            return await _context.Schools.ToListAsync();
        }

        public async Task<School> GetSchoolById(int schoolId)
        {
            return await _context.Schools.Where(i => i.Id == schoolId).FirstOrDefaultAsync();
        }
    }
}
