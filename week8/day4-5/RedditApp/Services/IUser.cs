using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RedditApp.Models;

namespace RedditApp.Services
{
    public interface IUser
    {
        public void Register(string nickname, string password, string email);
        public void Login(string nickname, string password);
        public List<User> ReturnUsers();
        public void Logout();
    }
}
