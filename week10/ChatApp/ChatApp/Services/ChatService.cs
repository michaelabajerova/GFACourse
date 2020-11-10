using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using ChatApp.Models;
using ChatApp.Models.Get;
using ChatApp.Models.Post;
using Newtonsoft.Json;

namespace ChatApp.Services
{
    public class ChatService
    {
        public static string ApiKey { get; set; }

        private readonly IHttpClientFactory clientFactory;

        public ChatService(IHttpClientFactory clientFactory)
        {
            this.clientFactory = clientFactory;
        }
        public User Register(string login, string password)
        {
            var model = new User(login, password);
            var toSend = JsonConvert.SerializeObject(model);
            var httpContent = new StringContent(toSend, Encoding.UTF8, "application/json");

            var response = clientFactory.CreateClient().PostAsync("https://latest-chat.herokuapp.com/api/user/register", httpContent).Result;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                model = JsonConvert.DeserializeObject<User>(responseContent);
            }
            return model;
        }

        public Dictionary<string, string> Login(UserCredentials loginCredentials)
        {
            var credentials = JsonConvert.SerializeObject(new UserCredentials { Login = loginCredentials.Login, Password = loginCredentials.Password });
            var requestContext = new StringContent(credentials, Encoding.UTF8, "application/json");

            requestContext.Headers.Add("apiKey", ApiKey);

            string endpointUrl = "https://latest-chat.herokuapp.com/api/user/login";

            var response = clientFactory.CreateClient().PostAsync(endpointUrl, requestContext).Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;
            var loginInfo = JsonConvert.DeserializeObject<Dictionary<string, string>>(responseContent);

            loginInfo.TryGetValue("apiKey", out string apiKey);

            ApiKey = apiKey;
            Console.WriteLine("Your API KEY = " + apiKey);
            return loginInfo;
        }
        public User Update(string username, string avatarUrl, string apiKey)
        {
            var model = new User() { Username = username, AvatarUrl = avatarUrl };
            var toSend = JsonConvert.SerializeObject(model);
            var httpContent = new StringContent(toSend, Encoding.UTF8, "application/json");

            httpContent.Headers.Add("apiKey", apiKey);

            var response = clientFactory.CreateClient().PostAsync("https://latest-chat.herokuapp.com/api/user/update", httpContent).Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;
            var modelResult = JsonConvert.DeserializeObject<User>(responseContent);

            return modelResult;
        }

        public bool Logout(string apiKey)
        {
            var model = new User();
            var toSend = JsonConvert.SerializeObject(model);
            var httpContent = new StringContent(toSend, Encoding.UTF8, "application/json");
            httpContent.Headers.Add("apiKey", apiKey);

            var response = clientFactory.CreateClient().PostAsync("https://latest-chat.herokuapp.com/api/user/logout", httpContent).Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<bool>(responseContent);

            return result;
        }
    }
}