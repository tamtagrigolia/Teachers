using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teachers.Models;

namespace Teachers.Service.interfaces
{
    public interface IGroupService
    {
Task AddGroupAsync(Group group);
        Task DeleteGroupAsync(string Name);
        Task DeleteStudentForGroupAsync(int StudentId);
        Task updateStudentForGroupAsync(int exsistingStudentId, int newStudentId);
        Task updateTeacherForGroup(int exsistingSubjectId, int newSubjectId);

    }
}
