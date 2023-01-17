using NttData.FileManagement.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NttData.FileManagement.Business.WinSite.Contracts
{
    public interface IStudentService
    {
        bool Add(Student student);
    }
}
