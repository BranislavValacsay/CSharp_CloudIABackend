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
    public class AUTH_Job_StartDate : _BaseAPIController
    {
        public readonly NetRunnersBackendContext _context;

        public AUTH_Job_StartDate(NetRunnersBackendContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<JobOfferStartDate>> Newitem(JobOfferStartDate item)
        {
            _context.JobOfferStartDate.Add(item);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult<JobOfferStartDate>> ChangeName(JobOfferStartDate item)
        {
            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
