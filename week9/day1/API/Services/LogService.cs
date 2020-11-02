using System;
using System.Collections.Generic;
using System.Linq;
using API.Database;
using API.Models;

namespace API.Services
{
    public class LogService
    {
        private ApplicationContext appContext;

        public LogService(ApplicationContext appContext)
        {
            this.appContext = appContext;
        }

        public void AddLog(string endpoint, string data)
        {
            using (var context = appContext)
            {
                context.Logs.Add(new Log(endpoint, DateTime.Now, data));
                context.SaveChanges();
            }
        }

        public List<Log> ReturnAllLogs()
        {
            using (var context = appContext)
            {
                return context.Logs.ToList();
            }
        }
    }
}