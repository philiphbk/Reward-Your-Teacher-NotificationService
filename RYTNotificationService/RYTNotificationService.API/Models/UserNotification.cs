using System.ComponentModel.DataAnnotations;

namespace RYTNotificationService.API.Models
{
    public class UserNotification : BaseEntity
    {

        [Required]
        public string SenderUserName { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]

        public DateTime? DateRead { get; set; }
        public bool IsRead { get; set; }
        public bool SenderDeleted { get; set; }
        public virtual Notification Notifications { get; set; }
    }
}