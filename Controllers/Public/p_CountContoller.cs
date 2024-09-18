using CloudIABackend.Data;
using CloudIABackend.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CloudIABackend.Models;
using Microsoft.AspNetCore.Authorization;

namespace CloudIABackend.Controllers.Public
{
    public class P_CountContoller : _BaseAPIController
    {
        public readonly NetRunnersBackendContext _context;

        public P_CountContoller(NetRunnersBackendContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<string>> CountOffers()
        {
            var result = await _context.JobOffers.Where(x => x.JobClosed != true).Select(x => x.Id).ToListAsync();
            return result.Count().ToString();
        }

    }


}
