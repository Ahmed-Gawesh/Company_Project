using Project.BL.Interfaces;
using Project.DAL.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BL.Repositoties
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ProjectDbContext dbContext;

        public IEmployeeRepository employeeRepository { get ; set; }
        public IDepartmentRepository departmentRepository { get ; set ; }

        public UnitOfWork(ProjectDbContext dbContext)
        {
            employeeRepository=new EmployeeRepository(dbContext);
            departmentRepository=new DepartmentRepository(dbContext);
            this.dbContext = dbContext;
        }

        public async Task<int> Complete()
           => await dbContext.SaveChangesAsync();

        public void Dispose()
        =>dbContext.Dispose();
    }
}
