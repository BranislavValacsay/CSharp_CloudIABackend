using CloudIABackend.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using CloudIABackend.DTO;

namespace CloudIABackend.Controllers.Enumerations
{
    [Route("api/[controller]")]
    [ApiController]
    public class ENUM_JobTechstackCategoryController : _BaseAPIController
    {
        private readonly NetRunnersBackendContext _context;

        public ENUM_JobTechstackCategoryController(NetRunnersBackendContext context)
        {
            _context = context;
        }
        
        [HttpGet]

        public async Task<ActionResult<IEnumerable<ENUM_JobTechstackCategoryDTO>>> GetTechstackCategories()
        {
            return await _context.ENUM_JobTechStackCategory.Select(
                DTO => new ENUM_JobTechstackCategoryDTO
                {
                    Id = DTO.Id,
                    CategoryName = DTO.CategoryName,
                }).ToListAsync();
        }
    }
}
