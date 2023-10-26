namespace Notification_Service
{
    public interface IFCM_Service
    {
        Task SendNotification(string token, string title, string body);
    }
}