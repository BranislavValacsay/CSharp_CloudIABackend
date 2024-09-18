using CloudIABackend.Data;
using CloudIABackend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudIABackend.Controllers.Public
{
    public class P_ContactController : _BaseAPIController
    {
        public readonly NetRunnersBackendContext _context;

        public P_ContactController(NetRunnersBackendContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<Contact>> CreateOffer(Contact ContactUs)
        {
            var TimeStamp = DateTime.Now;
            ContactUs.visitTime = TimeStamp.ToString("HH:mm:ss");
            ContactUs.visitDate = TimeStamp.ToString("dd-MM-yyyy");
            _context.Contact.Add(ContactUs);
            await _context.SaveChangesAsync();
            return Ok(ContactUs);
        }
    }
}
