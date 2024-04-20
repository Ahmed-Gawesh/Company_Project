using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BL.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        public IEmployeeRepository employeeRepository { get; set; }

        public IDepartmentRepository departmentRepository { get; set; }

        public Task<int> Complete();
    }
}
