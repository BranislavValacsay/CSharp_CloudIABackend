using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.StaticFiles;
using System.IO;

namespace CloudIABackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class test : _BaseAPIController
    {
        [HttpGet]
        public OkObjectResult testTask1()
        {
            return Ok("I am working, hello :)");
        }

        [HttpGet("Also")] //path would be /api/test/also
        public OkObjectResult testTask2()
        {
            return Ok("I am ALSO working, hello :)");
        }

        [HttpGet("gf/{fname}")] //path would be /api/test/gf
        public async Task<FileResult> testTask3Async(string fname)
        {
            //Uri restUri = new Uri("https://localhost:44377/api/test/gf");
            string localTarget = @"C:\Temp\"+fname+".exe";

            /*
            using (var webClient = new WebClient())
            {
                webClient.DownloadFile(restUri, localTarget);
            }

            return Ok("I am ALSO working, hello :)");
            */

            var provider = new FileExtensionContentTypeProvider();
            if (!provider.TryGetContentType(localTarget, out var contentType))
            {
                contentType = "application/octet-stream";
            }

            var bytes = await System.IO.File.ReadAllBytesAsync(localTarget);
            return File(bytes, contentType, Path.GetFileName(localTarget));
        }
    }
}
