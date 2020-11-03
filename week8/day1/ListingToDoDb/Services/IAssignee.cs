using System;
using System.Collections.Generic;
using ListingToDoDb.Models.Entities;
using ListingToDoDb.Models.ViewModels;

namespace ListingToDoDb.Services
{
    public interface IAssignee
    {
        List<Assignee> ListAllAssignees();
        void AddAssignee(Assignee newAssignee);
        void DeleteAssignee(int id);
        void UpdateAssignee(Assignee updatedAssignee);
        Assignee GetAssignee(int id);

    }
}