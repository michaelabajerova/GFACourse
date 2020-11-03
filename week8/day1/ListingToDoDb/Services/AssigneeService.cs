using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListingToDoDb.Database;
using ListingToDoDb.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ListingToDoDb.Services
{
    public class AssigneeService : IAssignee
    {
        private readonly ApplicationContext appContext;

        public AssigneeService(ApplicationContext appContext)
        {
            this.appContext = appContext;
        }

        public void AddAssignee(Assignee newAssignee)
        {
            appContext.Assignee.Add(newAssignee);
            appContext.SaveChanges();
        }

        public void DeleteAssignee(int id)
        {
            appContext.Assignee.Remove(GetAssignee(id));
            appContext.SaveChanges();
        }

        public Assignee GetAssignee(int id)
        {
            return appContext.Assignee.Include(a => a.AssignedTodos).Where(a => a.Id == id).SingleOrDefault();
        }

        public List<Assignee> ListAllAssignees()
        {
            return appContext.Assignee.Include(a => a.AssignedTodos).ToList();
        }

        public void UpdateAssignee(Assignee updatedAssignee)
        {
            appContext.Assignee.Update(updatedAssignee);
            appContext.SaveChanges();
        }
    }
}
