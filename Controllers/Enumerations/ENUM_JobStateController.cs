using CloudIABackend.Data;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using CloudIABackend.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using System.Linq;

namespace CloudIABackend.Controllers.Enumerations
{
    public class ENUM_JobStateController : _BaseAPIController
    {
        private readonly NetRunnersBackendContext _context;
        public ENUM_JobStateController(NetRunnersBackendContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ENUM_JobState>>> GetJobState()
        {
            return await _context.ENUM_JobState.OrderBy(m => m.StateChips).ToListAsync();
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult<ENUM_JobType>> PostJobState(ENUM_JobState jobState)
        {
            _context.ENUM_JobState.Add(jobState);
            await _context.SaveChangesAsync();
            return Ok(jobState);
        }
    }
}
