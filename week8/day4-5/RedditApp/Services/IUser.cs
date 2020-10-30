using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RedditApp.Models;

namespace RedditApp.Services
{
    public interface IUser
    {
        List<User> GetUsers();
        public void Register(string name, string password, string email);
    }
}
