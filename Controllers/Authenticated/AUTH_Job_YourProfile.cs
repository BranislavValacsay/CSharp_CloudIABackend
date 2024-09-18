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
    public class AUTH_Job_YourProfile : _BaseAPIController
    {
        public readonly NetRunnersBackendContext _context;

        public AUTH_Job_YourProfile(NetRunnersBackendContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<JobOfferYourProfile>> NewTitle(JobOfferYourProfile Item)
        {
            _context.JobOfferYourProfile.Add(Item);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult<JobOfferYourProfile>> ChangeName(JobOfferYourProfile Item)
        {
            _context.Entry(Item).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
