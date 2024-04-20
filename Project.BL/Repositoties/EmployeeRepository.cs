using Project.BL.Interfaces;
using Project.DAL.Contexts;
using Project.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BL.Repositoties
{
    public class EmployeeRepository:GenericRepository<Employee>, IEmployeeRepository
    {
        private readonly ProjectDbContext dbContext;

        public EmployeeRepository(ProjectDbContext dbContext):base(dbContext) 
        {
            this.dbContext = dbContext;
        }

        public IQueryable<Employee> GetEmployeeByName(string name)
         => dbContext.Employees.Where(E => E.Name.ToLower().Contains(name.ToLower()));
    }
}
