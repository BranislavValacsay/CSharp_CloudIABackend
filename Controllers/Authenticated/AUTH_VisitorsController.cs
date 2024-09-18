using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CloudIABackend.Data;
using CloudIABackend.Models;
using Microsoft.AspNetCore.Authorization;

namespace CloudIABackend.Controllers.Authenticated
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AUTH_VisitorsController : ControllerBase
    {
        private readonly NetRunnersBackendContext _context;

        public AUTH_VisitorsController(NetRunnersBackendContext context)
        {
            _context = context;
        }

        // GET: api/Visitors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Visitors>>> GetVisitors()
        {
            return await _context.Visitors.ToListAsync();
        }

    }
}
