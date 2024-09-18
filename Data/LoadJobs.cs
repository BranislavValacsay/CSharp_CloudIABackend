using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudIABackend.DTO;
using CloudIABackend.Helpers;
using CloudIABackend.Interface;
using CloudIABackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CloudIABackend.Data
{
    public class LoadJobs : ILoadJobs
    {
        private readonly NetRunnersBackendContext _context;
        public LoadJobs(NetRunnersBackendContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<JobDetailDto>> JobDetailUrl(string JobUrl, getIP getIP)
        {

            var result = await _context.JobOffers
                .Include(t => t.ClassTechStack)
                .Where(x => x.JobUrl == JobUrl)
                .Select(job => new JobDetailDto
                {
                    JobGuid = job.Guid,
                    JobTitle = job.JobTitle,
                    Language = job.Language,
                    State = job.State,
                    City = job.City,
                    JobDescription = job.JobDescription,
                    YourProfile = job.YourProfile,
                    YouCanExpect = job.YouCanExpect,
                    FurtherInformation = job.FurtherInformation,
                    StartDate = job.StartDate,
                    Salary = job.Salary,

                    TechStack = (ICollection<ENUM_JobTechStacKDTO>)job.ClassTechStack.Select(
                        TechStacks => new ENUM_JobTechStacKDTO
                        {
                            Id = TechStacks.TechStackSkillId,
                            SkillChips = TechStacks.TechStack.SkillChips,
                            CategoryId = TechStacks.TechStack.CategoryId,
                            CategoryName = TechStacks.TechStack.Category.CategoryName

                        }
                    ),
                    Tasks = job.Tasks,
                    JobUrl = job.JobUrl,
                    JobType = job.JobType,
                    PrimarySkill = job.PrimarySkill,
                    SecondarySkill = job.SecondarySkill
                })
                .SingleOrDefaultAsync();

            return result;
        }


        public async Task<IEnumerable<JobOfferDto>> ListJobs(FilterParams filterParams)
        {
            var result = _context.JobOffers
                .Include(p => p.ClassTechStack)
                .Select(job => new JobOfferDto
                {
                    JobGuid = job.Guid,
                    JobTitle = job.JobTitle,
                    Language = job.Language,
                    State = job.State,
                    JobClosed = job.JobClosed,
                    JobUrl = job.JobUrl,
                    Salary = job.Salary,
                    JobType = job.JobType,
                    Tasks = job.Tasks,

                    TechStack = (ICollection<ENUM_JobTechStacKDTO>)job.ClassTechStack.Select(
                        TechStacks => new ENUM_JobTechStacKDTO
                        {
                            Id = TechStacks.TechStackSkillId,
                            SkillChips = TechStacks.TechStack.SkillChips,
                            CategoryId = TechStacks.TechStack.CategoryId,
                            CategoryName = TechStacks.TechStack.Category.CategoryName
                        }
                    ),

                    PrimarySkill = job.PrimarySkill,
                    SecondarySkill = job.SecondarySkill

                }).Where(x => x.JobClosed != true);

            if (filterParams.title != null) { result = result.Where(x => x.JobTitle.Contains(filterParams.title)); }
            if (filterParams.language != null) { result = result.Where(x => x.Language.Contains(filterParams.language)); }
            if (filterParams.jobType != null)
            {
                string[] arrType = filterParams.jobType.Split(",");
                result = result.Where(x => arrType.Contains(x.JobType));
            }

            var res = await result.ToListAsync();

            if (filterParams.techStack != null)
            {
                string arrSkill = filterParams.techStack;
                res = res.Where(x => x.TechStack.Any(x => x.SkillChips.Contains(arrSkill, StringComparison.OrdinalIgnoreCase))).ToList();

            }
            return res.ToList();

        }
    }
}
    
