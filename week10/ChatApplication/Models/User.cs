using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApplication.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Login { get; set; }
        public string Username { get; set; }
        public string AvatarUrl { get; set; }
        public string ApiKey { get; set; }
    }
}
