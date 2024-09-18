using CloudIABackend.DTO;
using CloudIABackend.Helpers;
using CloudIABackend.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CloudIABackend.Data
{
    public class AuthJobWorker : IAuthJobWorker
    {
        private readonly NetRunnersBackendContext _context;
        public AuthJobWorker(NetRunnersBackendContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<AUTH_JobDetailDTO>> JobDetailUrl(string JobUrl)
        {

            var result = await _context.JobOffers
                .Include(t => t.ClassTechStack)
                .Where(x => x.JobUrl == JobUrl)
                .Select(job => new AUTH_JobDetailDTO
                {
                    Guid = job.Guid,
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
                    TimesSeen = job.TimesSeen,
                    JobType = job.JobType,
                    Source = job.Source,
                    SourceId = job.SourceId,
                    SourceUrl = job.SourceUrl,
                    JobClosed = job.JobClosed,
                    PrimarySkill = job.PrimarySkill,
                    SecondarySkill = job.SecondarySkill

                })
                .SingleOrDefaultAsync();
            return result;
        }
        public async Task<IEnumerable<AUTH_JobOfferDto>> ListJobs(FilterParams filterParams)
        {
            var result = _context.JobOffers.Select(job => new AUTH_JobOfferDto
            {
                //Id = job.Id,
                JobTitle = job.JobTitle,
                Language = job.Language,
                State = job.State,
                JobClosed = job.JobClosed,
                JobUrl = job.JobUrl,
                SourceUrl = job.SourceUrl,
                Source = job.Source,
                SourceID = job.SourceId,
                JobType = job.JobType,
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
            });

            if (filterParams.title != null) { result = result.Where(x => x.JobTitle.Contains(filterParams.title)); }
            if (filterParams.language != null) { result = result.Where(x => x.Language == filterParams.language); }
            if (filterParams.jobType != null)
            {
                string[] arr = filterParams.jobType.Split(",");
                result = result.Where(x => arr.Contains(x.JobType));
            }
            result = result.Where(x => x.JobClosed == filterParams.jobClosed);

            var res = await result.ToListAsync();

            if (filterParams.techStack != null)
            {
                string[] arrSkill = filterParams.techStack.Split(",");
                res = res.Where(x => x.TechStack.Any(x => arrSkill.Contains(x.SkillChips))).ToList();

            }

            return res.ToList();

        }

    }
}
