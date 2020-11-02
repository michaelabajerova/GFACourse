using System;
using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Log
    {
        [Key]
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }
        public string EndPoint { get; set; }
        public string Data { get; set; }

        public Log(string endpoint, DateTime createdAt, string data)
        {
            EndPoint = endpoint;
            CreatedAt = createdAt;
            Data = data;
        }

        public Log()
        {
        }
    }
}