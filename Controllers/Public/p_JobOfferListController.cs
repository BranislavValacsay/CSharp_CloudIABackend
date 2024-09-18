using CloudIABackend.Data;
using CloudIABackend.DTO;
using CloudIABackend.Helpers;
using CloudIABackend.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CloudIABackend.Controllers.Public
{
    public class P_JobOfferListController : _BaseAPIController
    {
        public readonly ILoadJobs _loadJobs;
        public readonly NetRunnersBackendContext _context;

        public P_JobOfferListController(NetRunnersBackendContext context, ILoadJobs loadJobs)
        {
            _loadJobs = loadJobs;
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<JobOfferDto>> LoadOffers([FromQuery] FilterParams filterParams)
        {
            return await _loadJobs.ListJobs(filterParams);
        }

        [HttpGet("{JobUrl}")]
        public async Task<ActionResult<JobDetailDto>> LoadOfferUrl(string JobUrl, [FromQuery] getIP getIP)
        {
            return await _loadJobs.JobDetailUrl(JobUrl, getIP);
        }
    }
}