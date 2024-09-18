using CloudIABackend.Data;
using CloudIABackend.Models.JobOfferClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CloudIABackend.Controllers.Authenticated
{
    [Route("api/[controller]")]
    [ApiController]

    [Authorize]
    public class AUTH_Job_SecondarySkill : _BaseAPIController
    {
        public readonly NetRunnersBackendContext _context;

        public AUTH_Job_SecondarySkill(NetRunnersBackendContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<JobOfferSecondarySkill>> NewTitle(JobOfferSecondarySkill title)
        {
            _context.JobOfferSecondarySkill.Add(title);
            await _context.SaveChangesAsync();
            return Ok("Ok");
        }

        [HttpPut]
        public async Task<ActionResult<JobOfferSecondarySkill>> ChangeName(JobOfferSecondarySkill title)
        {
            _context.Entry(title).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok("Ok");
        }
    }
}
