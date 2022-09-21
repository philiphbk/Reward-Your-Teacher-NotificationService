using System.ComponentModel.DataAnnotations;

namespace RYTNotificationService.API.Models
{
    public class BaseEntity
    {
        [Key]
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }



        public BaseEntity()
        {
            Id = Guid.NewGuid().ToString();
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
        
    }
}
