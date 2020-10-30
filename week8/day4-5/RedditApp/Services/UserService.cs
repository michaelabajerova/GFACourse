using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RedditApp.Database;
using RedditApp.Models;

namespace RedditApp.Services
{
    public class UserService : IUser
    {
        private readonly ApplicationContext userContext;
        public UserService(ApplicationContext userContext)
        {
            this.userContext = userContext;
        }
        public List<User> GetUsers()
        {
            return userContext.Users.ToList();
        }
        public void Register(string name, string password, string email)
        {
            var newUser = new User(name, password, email);
            userContext.Users.Add(newUser);
            userContext.SaveChanges();
        }
    }
}
