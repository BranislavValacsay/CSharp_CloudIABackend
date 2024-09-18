using CloudIABackend.Data;
using CloudIABackend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudIABackend.Controllers.Public
{
    public class P_ApplyJobController : _BaseAPIController
    {
        public readonly NetRunnersBackendContext _context;
        public P_ApplyJobController(NetRunnersBackendContext context)
        {
            _context = context;
        }


        [HttpPost]
        public async Task<ActionResult<CandidateApplications>> CreateOffer(CandidateApplications CandidateApplications)
        {
            var TimeStamp = DateTime.Now;
            CandidateApplications.visitTime = TimeStamp.ToString("HH:mm:ss");
            CandidateApplications.visitDate = TimeStamp.ToString("dd-MM-yyyy");

            _context.CandidateApplications.Add(CandidateApplications);
            await _context.SaveChangesAsync();
            return Ok(CandidateApplications);
        }
    }
}
