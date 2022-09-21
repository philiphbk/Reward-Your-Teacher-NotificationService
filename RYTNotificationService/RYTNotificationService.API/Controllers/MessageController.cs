using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RYTNotificationService.API.Data.Implementation;
using RYTNotificationService.API.Extensions;

namespace RYTNotificationService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessageService _messageServe;

        public MessageController(IMessageService messageService)
        {
            _messageServe = messageService;
        }

        [HttpDelete("delete-message-by-id/{id}")]
        public ActionResult DeleteMessage(string id)
        {
            //var username = User.GetUserName();
            _messageServe.DeleteMessageById(id);
            return Ok();
        }

        /*public async Task<ActionResult> DeleteMessaging(string id)
        {
            var username = User.GetUserName();
            var message = await _messageServe.GetMessage(id);

            if ()
        }*/
    }
}
