using CloudIABackend.Data;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using CloudIABackend.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using System.Linq;
using CloudIABackend.DTO;

namespace CloudIABackend.Controllers.Enumerations
{
    public class ENUM_JobTypeController : _BaseAPIController
    {
        private readonly NetRunnersBackendContext _context;

        public ENUM_JobTypeController(NetRunnersBackendContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ENUM_JobTypeDTO>>> GetJobType()
        {
            return await _context.ENUM_JobType
                .OrderBy(m => m.TypeChips)
                .Select(type => new ENUM_JobTypeDTO
                {
                    Id = type.Id,
                    TypeChips = type.TypeChips
                })
                .ToListAsync();
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult<ENUM_JobType>> PostJobType(ENUM_JobType jobType)
        {
            _context.ENUM_JobType.Add(jobType);
            await _context.SaveChangesAsync();
            return Ok(jobType);
        }
    }
}
