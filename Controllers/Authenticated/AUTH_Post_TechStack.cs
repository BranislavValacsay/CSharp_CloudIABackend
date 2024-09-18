using CloudIABackend.Data;
using CloudIABackend.DTO;
using CloudIABackend.Models;
//using CloudIABackend.Models.JobOfferClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudIABackend.Controllers.Authenticated
{
    [Route("api/[controller]")]
    [ApiController]
    public class AUTH_Post_TechStack : _BaseAPIController
    {
        public readonly NetRunnersBackendContext _context;
        public AUTH_Post_TechStack(NetRunnersBackendContext context)
        {
            _context = context;
        }

        [HttpGet("{guid}")]
        public async Task<ActionResult<IEnumerable<JobOfferTechStackDTO>>> Id_techstack(string guid)
        {
            return await _context.JobOfferTechstack
                .Where(x => x.JobGuid == guid)
                .Select(TechStack => new JobOfferTechStackDTO
                {
                    JobGuid = TechStack.JobGuid,
                    techStackSkillId = TechStack.TechStackSkillId,
                }).ToListAsync();
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult<IEnumerable<JobOfferTechStack>>> Post_Id_techstack(JobOfferTechStackDTO item)
        {
            var itemToSend = new JobOfferTechStack
            {
                JobGuid = item.JobGuid,
                TechStackSkillId = item.techStackSkillId
            };
            _context.JobOfferTechstack.Add(itemToSend);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [Authorize]
        [HttpDelete]

        public async Task<ActionResult<IEnumerable<JobOfferTechStack>>> Del_Id_techstack(JobOfferTechStack item)
        {
      
            _context.JobOfferTechstack.Remove(item);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
