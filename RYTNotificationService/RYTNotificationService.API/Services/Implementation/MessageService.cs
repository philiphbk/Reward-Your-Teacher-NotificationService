using Microsoft.EntityFrameworkCore;
using RYTNotificationService.API.DTOs;
using RYTNotificationService.API.Models;

namespace RYTNotificationService.API.Data.Implementation
{
    public class MessageService : IMessageService
    {
        private readonly DataContext _messageContext;

        public MessageService(DataContext dataContext)
        {
            _messageContext = dataContext;
        }
        
        public void DeleteMessageById(string id)
        {
            var deleteItem = _messageContext.Messages.Where(x => x.Id == id).Select(mess => new Message()
            {
                SenderId = mess.SenderId,
                RecipientId = mess.RecipientId,
            }).FirstOrDefault();
            if (deleteItem != null)
            {
                _messageContext.Messages.Remove(deleteItem);
                _messageContext.SaveChanges();
            }
        }

   
    }
}
