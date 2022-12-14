using EmailSenders.Entity;
using EmailSenders.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace EmailSenders.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailController : ControllerBase
    {
        private readonly IMailService mailService;
        public MailController(IMailService mailService)
        {
            this.mailService = mailService;
        }
        [HttpPost("SendEmail")]
        public async Task<IActionResult> SendMail([FromForm] MailRequest request)
        {
           var result = await mailService.SendEmailAsync(request);
           if (result.Success) return Ok(result);
           
           return BadRequest(result);
        }

    }
}
