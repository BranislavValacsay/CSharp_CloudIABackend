using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudIABackend.DTO;
using CloudIABackend.Helpers;
using CloudIABackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace CloudIABackend.Interface
{
    public interface ILoadJobs
    {
        Task<IEnumerable<JobOfferDto>> ListJobs(FilterParams filterParams);
        Task<ActionResult<JobDetailDto>> JobDetailUrl(string JobUrl, getIP getIP);

    }
}
