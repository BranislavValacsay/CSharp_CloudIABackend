﻿using CloudIABackend.Data;
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
    public class AUTH_Job_JobType : _BaseAPIController
    {
        public readonly NetRunnersBackendContext _context;

        public AUTH_Job_JobType(NetRunnersBackendContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<JobOfferType>> New(JobOfferType title)
        {
            _context.JobOfferType.Add(title);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult<JobOfferType>> Change(JobOfferType title)
        {
            _context.Entry(title).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
