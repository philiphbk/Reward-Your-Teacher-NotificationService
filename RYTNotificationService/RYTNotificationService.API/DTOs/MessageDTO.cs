namespace RYTNotificationService.API.DTOs
{
    public class MessageDTO
    {
        public string SenderUserName { get; set; }
        public string RecipientUserName { get; set; }
        public string Content { get; set; }
        public DateTime? DateRead { get; set; }
        public DateTime MessageSent { get; set; } = DateTime.UtcNow;
        
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
    }
}
