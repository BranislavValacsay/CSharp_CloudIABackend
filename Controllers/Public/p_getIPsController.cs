using CloudIABackend.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.HttpOverrides;

namespace CloudIABackend.Controllers.Public
{
    [ApiController]
    public class getIPs : _BaseAPIController
    {
        public readonly NetRunnersBackendContext _context;

        public getIPs(NetRunnersBackendContext context)
        {
            _context = context;

        }
        [HttpGet]
        public string Get()
        {
            var remoteIpAddress = HttpContext.Connection.RemoteIpAddress;
            return "{\"ipaddress\" : " + "\"" + remoteIpAddress.ToString() + "\"}";
        }
    }
}
