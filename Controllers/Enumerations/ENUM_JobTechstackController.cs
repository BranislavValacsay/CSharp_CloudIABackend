using CloudIABackend.Data;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using CloudIABackend.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using System.Linq;
using CloudIABackend.DTO;

namespace CloudIABackend.Controllers.Enumerations
{

    public class ENUM_JobTechstackController : _BaseAPIController
    {
        private readonly NetRunnersBackendContext _context;
        public ENUM_JobTechstackController(NetRunnersBackendContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ENUM_JobTechStacKDTO>>> GetJobTechStack()
        {
            return await _context.ENUM_JobTechStack.Select(
                DTO => new ENUM_JobTechStacKDTO
                {
                    Id = DTO.Id,
                    SkillChips = DTO.SkillChips,
                    CategoryName = DTO.Category.CategoryName,
                    CategoryId = DTO.CategoryId,
                }
                ).OrderBy(p => p.SkillChips).ToListAsync();
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult<ENUM_JobTechStack>> PostJobTechStack(ENUM_JobTechStack jobTechStack)
        {
            if (await SkillExists(jobTechStack.SkillChips)) return BadRequest("Skill already exists");

            _context.ENUM_JobTechStack.Add(jobTechStack);
            await _context.SaveChangesAsync();
            return Ok(jobTechStack.Id);
        }

        private async Task<bool> SkillExists(string skillName)
        {
            return await _context.ENUM_JobTechStack.AnyAsync(x => x.SkillChips == skillName.ToLower());
        }
    }
}
