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
    public class AUTH_Job_Description : _BaseAPIController
    {
        public readonly NetRunnersBackendContext _context;

        public AUTH_Job_Description(NetRunnersBackendContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<JobOfferDescription>> NewDescription(JobOfferDescription Description)
        {
            _context.JobOfferDescrition.Add(Description);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult<JobOfferDescription>> ChangeName(JobOfferDescription Description)
        {
            _context.Entry(Description).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch
            {
                return BadRequest("Unable to modify object");
            }
        }
    }
}
