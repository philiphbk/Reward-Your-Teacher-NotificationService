﻿namespace RYTNotificationService.API.Models
{
    public class Response<T>
    {
        public bool Success { get; set; } = false;
        public T Data { get; set; }
        public string Message { get; set; }
    }
}
