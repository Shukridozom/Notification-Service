using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Notification_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FCMController : ControllerBase
    {
        private readonly IFCM_Service fcm;

        public FCMController(IFCM_Service fcm)
        {
            this.fcm = fcm;
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> SendNotification(NotificationDto notification)
        {
            try
            {
                await fcm.SendNotification(notification.Token, notification.Title, notification.Body);

            }
            catch (Exception)
            {

                return BadRequest("Unvalid FCM Token");
            }
            return Ok();
        }
    }
}
