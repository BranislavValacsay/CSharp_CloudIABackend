using CloudIABackend.Data;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using CloudIABackend.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using System.Linq;

namespace CloudIABackend.Controllers.Enumerations
{

    public class ENUM_JobCityController : _BaseAPIController
    {
        private readonly NetRunnersBackendContext _context;
        public ENUM_JobCityController(NetRunnersBackendContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ENUM_JobCity>>> GetJobCity()
        {
            return await _context.ENUM_JobCity.OrderBy(m => m.CityChips).ToListAsync();
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult<ENUM_JobCity>> PostJobCity(ENUM_JobCity jobCity)
        {
            _context.ENUM_JobCity.Add(jobCity);
            await _context.SaveChangesAsync();
            return Ok(jobCity);
        }
    }
}
