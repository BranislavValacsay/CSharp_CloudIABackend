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
    public class AUTH_Job_City : _BaseAPIController
    {
        public readonly NetRunnersBackendContext _context;

        public AUTH_Job_City(NetRunnersBackendContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<JobOfferCity>> NewTitle(JobOfferCity title)
        {
            _context.JobOfferCity.Add(title);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult<JobOfferCity>> ChangeName(JobOfferCity title)
        {
            _context.Entry(title).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
