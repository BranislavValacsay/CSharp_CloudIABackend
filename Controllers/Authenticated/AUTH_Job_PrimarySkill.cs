using CloudIABackend.Data;
using CloudIABackend.Models.JobOfferClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Threading.Tasks;

namespace CloudIABackend.Controllers.Authenticated
{
    [Route("api/[controller]")]
    [ApiController]

    [Authorize]
    public class AUTH_Job_PrimarySkill : _BaseAPIController
    {
        public readonly NetRunnersBackendContext _context;

        public AUTH_Job_PrimarySkill(NetRunnersBackendContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<JobOfferPrimarySkill>> NewTitle(JobOfferPrimarySkill title)
        {
            var x = await GetPrimarySkill(title);
            if (x.Value == null)
            {
                _context.JobOfferPrimarySkill.Add(title);
                await _context.SaveChangesAsync();
                return Ok("entry created");
            }
            else
                _context.Entry(title).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok("entry changed");

        }

        private async Task<ActionResult<JobOfferPrimarySkill>> GetPrimarySkill (JobOfferPrimarySkill title)
        {
            return await _context.JobOfferPrimarySkill
                .Where(x => x.JobGuid == title.JobGuid)
                .AsNoTracking()
                .FirstOrDefaultAsync();
        }
    }
}
