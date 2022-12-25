using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IGroupService
    {
        void Create(Group group);
        void Update(Group group, int id);
        void Delete(Group group, int id);


    }
}
