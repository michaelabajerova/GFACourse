using System.Collections.Generic;

namespace DI.Services
{
    public interface IStudentService
    {
        public List<string> FindAll();
        void Save(string name);
        public int Count();
    }
}