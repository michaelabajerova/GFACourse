namespace ChatApp.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string AvatarUrl { get; set; }

        public string ApiKey { get; set; }
        public int UserId { get; set; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public User()
        {
        }
    }
}