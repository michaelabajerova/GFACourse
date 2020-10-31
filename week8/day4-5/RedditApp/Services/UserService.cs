using System.Collections.Generic;
using System.Linq;
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

        public void Login(string username, string password)
        {
            foreach (var user in userContext.Users)
            {
                if (user.Username == username && user.Password == password)
                {
                    user.Logged = true;
                }
            }
            userContext.SaveChanges();
        }

        public void Register(string nickname, string password, string email)
        {
            var user = new User(nickname, password, email);
            int value = 0;
            foreach (var item in userContext.Users)
            {
                if (item.Username == user.Username)
                {
                    value = 1;
                    break;
                }
            }
            if (value == 0)
            {
                userContext.Users.Add(user);
                userContext.SaveChanges();
            }
        }

        public void Logout()
        {
            foreach (var user in userContext.Users)
            {
                user.Logged = false;
            }
            userContext.SaveChanges();
        }

        public List<User> ReturnUsers()
        {
            return userContext.Users.ToList();
        }
    }
}