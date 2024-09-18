using CloudIABackend.Data;
using CloudIABackend.DTO;
using CloudIABackend.Helpers;
using CloudIABackend.Interface;
using CloudIABackend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;


namespace CloudIABackend.Controllers.Authenticated
{
    [Authorize]
    public class AUTH_Job : _BaseAPIController
    {
        public readonly IAuthJobWorker _authJobWorker;
        public readonly NetRunnersBackendContext _context;
        public AUTH_Job(NetRunnersBackendContext context, IAuthJobWorker authJobWorker)
        {
            _authJobWorker = authJobWorker;
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<AUTH_JobOfferDto>> LoadOffers([FromQuery] FilterParams filterParams)
        {
            return await _authJobWorker.ListJobs(filterParams);
        }


        [HttpGet("{JobUrl}")]
        public async Task<ActionResult<AUTH_JobDetailDTO>> LoadOfferUrl(string JobUrl)
        {
            return await _authJobWorker.JobDetailUrl(JobUrl);
        }

        [HttpPost]
        public async Task<ActionResult<JobOffer>> CreateOffer(JobOffer Offer)
        {
            Offer.Guid = Guid.NewGuid().ToString();

            _context.JobOffers.Add(Offer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("LoadOffers", new { guid = Offer.Id });
        }

        [HttpPatch("{guid}")]
        public async Task<ActionResult<JobOffer>> ChangeOffer(string guid, JobOffer Offer)
        {
            if (guid != Offer.Guid) { return BadRequest("Not found!"); }

            _context.Entry(Offer).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
                return AcceptedAtAction("ChangeOffer", new { guid = Offer.Guid });  //, Offer.Guid - for standalone value. Otherwise it is returned as JSON
            }
            catch
            {
                return BadRequest("Unable to modify object");
            }
        }
    }
}
