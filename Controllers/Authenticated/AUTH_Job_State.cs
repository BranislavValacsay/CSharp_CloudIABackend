using CloudIABackend.Data;
using CloudIABackend.Models.JobOfferClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CloudIABackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    [Authorize]
    public class AUTH_Job_State : _BaseAPIController
    {
        public readonly NetRunnersBackendContext _context;

        public AUTH_Job_State(NetRunnersBackendContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<JobOfferState>> New(JobOfferState state)
        {
            _context.JobOfferState.Add(state);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult<JobOfferState>> Change(JobOfferState state)
        {
            _context.Entry(state).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
