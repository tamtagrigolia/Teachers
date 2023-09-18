using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teachers.Models;
using Teachers.Service.interfaces;

namespace Teachers.Service
{
    internal class GroupService : IGroupService
    {
        public Task AddGroupAsync(Group group)
        {
            throw new NotImplementedException();
        }

        public Task DeleteGroupAsync(string Name)
        {
            throw new NotImplementedException();
        }

        public Task DeleteStudentForGroupAsync(int StudentId)
        {
            throw new NotImplementedException();
        }

        public Task updateStudentForGroupAsync(int exsistingStudentId, int newStudentId)
        {
            throw new NotImplementedException();
        }

        public Task updateTeacherForGroup(int exsistingSubjectId, int newSubjectId)
        {
            throw new NotImplementedException();
        }
    }
}
