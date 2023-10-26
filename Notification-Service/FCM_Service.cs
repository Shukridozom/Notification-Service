using FirebaseAdmin;
using FirebaseAdmin.Messaging;
using Google.Apis.Auth.OAuth2;

namespace Notification_Service
{
    public class FCM_Service : IFCM_Service
    {
        public async Task SendNotification(string token, string title, string body)
        {
            var notification = new Notification
            {
                Title = title,
                Body = body
            };
            var message = new Message
            {
                Notification = notification,
                Token = token
            };
            await FirebaseMessaging.DefaultInstance.SendAsync(message);
        }

    }
}
