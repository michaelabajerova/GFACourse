using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ChatApplication.Models;
using ChatApplication.Models.Get;
using Newtonsoft.Json;
using static ChatApplication.Models.GetChat;
using static ChatApplication.Models.PostChat;

namespace ChatApplication.Services
{
    public class ChatService
    {
        public static string ApiKey { get; set; }
        public static User LoggedIn { get; set; }
        public HttpClient _client;

        private readonly IHttpClientFactory clientFactory;
        public ChatService(IHttpClientFactory clientFactory)
        {
            this.clientFactory = clientFactory;
            _client = clientFactory.CreateClient();
            _client.DefaultRequestHeaders.Add("ApiKey", ChatService.ApiKey);
        }

        public PostChat Register(GetChat input)
        {
            var registerInfo = JsonConvert.SerializeObject(input);
            var httpContent = new StringContent(registerInfo, Encoding.UTF8, "application/json");

            string apiLink = "https://latest-chat.herokuapp.com/api/user/register";

            var response = _client.PostAsync(apiLink, httpContent).Result;
            var data = response.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<PostChat>(data);
        }

        public Dictionary<string, string> Login(GetChat input)
        {
            var loginInfo = JsonConvert.SerializeObject(input);
            var httpContent = new StringContent(loginInfo, Encoding.UTF8, "application/json");

            string apiLink = "https://latest-chat.herokuapp.com/api/user/login";

            var response = _client.PostAsync(apiLink, httpContent).Result;
            var data = response.Content.ReadAsStringAsync().Result;

            var returned = JsonConvert.DeserializeObject<Dictionary<string, string>>(data);
            returned.TryGetValue("apiKey", out string apiKey);
            ApiKey = apiKey;
            LoggedIn = new User() { ApiKey = ApiKey, Login = input.Login };
            return returned;
        }

        public PostChat UpdateUser(UpdateChat inputData, string apiKey)
        {
            var updateInfo = JsonConvert.SerializeObject(inputData);
            var httpContent = new StringContent(updateInfo, Encoding.UTF8, "application/json");

            string apiLink = "https://latest-chat.herokuapp.com/api/user/update";

            var response = _client.PostAsync(apiLink, httpContent).Result;
            var data = response.Content.ReadAsStringAsync().Result;

            var returned = JsonConvert.DeserializeObject<PostChat>(data);

            LoggedIn.Username = returned.Username;
            LoggedIn.UserId = returned.UserId;
            LoggedIn.AvatarUrl = inputData.AvatarUrl;
            return returned;
        }

        public bool LogoutUser()
        {
            var logoutInfo = JsonConvert.SerializeObject(LoggedIn);
            var httpContent = new StringContent(logoutInfo, Encoding.UTF8, "application/json");

            string apiLink = "https://latest-chat.herokuapp.com/api/user/logout";

            var response = _client.PostAsync(apiLink, httpContent).Result;
            var data = response.Content.ReadAsStringAsync().Result;

            LoggedIn = new User();
            ApiKey = String.Empty;

            return JsonConvert.DeserializeObject<bool>(data);
        }
    }
}
