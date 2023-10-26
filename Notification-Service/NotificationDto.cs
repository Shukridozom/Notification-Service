using System.ComponentModel.DataAnnotations;

namespace Notification_Service
{
    public class NotificationDto
    {
        [Required]
        public string Token { get; set; }
        [MaxLength(100)]
        public string? Title { get; set; }
        [MaxLength(900)]
        public string? Body { get; set; }
    }
}
