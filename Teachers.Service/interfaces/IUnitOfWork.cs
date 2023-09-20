using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teachers.Service.interfaces
{
    public interface IUnitOfWork
    {
        public ITeachersService Teacher { get; }
        public ISubjectService subject { get; }
        public IGroupService Group { get; }
    }
}
