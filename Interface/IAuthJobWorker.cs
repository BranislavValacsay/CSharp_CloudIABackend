using CloudIABackend.DTO;
using CloudIABackend.Helpers;
using CloudIABackend.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudIABackend.Interface
{
    public interface IAuthJobWorker
    {
        Task<IEnumerable<AUTH_JobOfferDto>> ListJobs(FilterParams filterParams);
        Task<ActionResult<AUTH_JobDetailDTO>> JobDetailUrl(string JobUrl);
    }
}
