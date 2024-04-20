using Project.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BL.Interfaces
{
    public interface IEmployeeRepository:IGenericRepository<Employee>
    {
        public IQueryable<Employee> GetEmployeeByName(string name);
    }
}
