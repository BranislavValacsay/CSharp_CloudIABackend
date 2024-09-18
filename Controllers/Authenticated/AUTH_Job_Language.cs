using CloudIABackend.Data;
using CloudIABackend.Models.JobOfferClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace CloudIABackend.Controllers.Authenticated
{
    [Route("api/[controller]")]
    [ApiController]


    [Authorize]
    public class AUTH_Job_Language : _BaseAPIController
    {
        public readonly NetRunnersBackendContext _context;

        public AUTH_Job_Language(NetRunnersBackendContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<JobOfferLanguage>> NewLanguage(JobOfferLanguage Language)
        {
            _context.JobOfferLanguage.Add(Language);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult<JobOfferLanguage>> ChangeLanguage(JobOfferLanguage Language)
        {
            _context.Entry(Language).State = EntityState.Modified;
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