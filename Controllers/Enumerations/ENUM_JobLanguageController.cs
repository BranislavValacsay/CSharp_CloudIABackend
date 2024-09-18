using CloudIABackend.Data;
using CloudIABackend.DTO;
using CloudIABackend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudIABackend.Controllers.Enumerations
{
    [Route("api/[controller]")]
    [ApiController]
    public class ENUM_JobLanguageController : _BaseAPIController
    {
        private readonly NetRunnersBackendContext _context;
        public ENUM_JobLanguageController(NetRunnersBackendContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ENUM_JobLanguageDTO>>> GetJobLanguage()
        {
            return await _context.ENUM_Language
                .OrderBy(m => m.LanguageChips)
                .Select(language => new ENUM_JobLanguageDTO
                {
                    Id = language.Id,
                    LanguageChips = language.LanguageChips
                })
                .ToListAsync();
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult<ENUM_JobLanguage>> PostJobLanguage(ENUM_JobLanguage jobLanguage)
        {
            _context.ENUM_Language.Add(jobLanguage);
            await _context.SaveChangesAsync();
            return Ok(jobLanguage);
        }
    }
}
