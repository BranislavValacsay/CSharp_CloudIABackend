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
    public class AUTH_Job_Tasks : _BaseAPIController
    {
        public readonly NetRunnersBackendContext _context;

        public AUTH_Job_Tasks(NetRunnersBackendContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<JobOfferTasks>> Newitem(JobOfferTasks item)
        {
            _context.JobOfferTasks.Add(item);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult<JobOfferTasks>> ChangeName(JobOfferTasks item)
        {
            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
