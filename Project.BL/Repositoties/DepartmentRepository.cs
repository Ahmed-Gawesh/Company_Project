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
    public class DepartmentRepository : GenericRepository<Department>,IDepartmentRepository
    {
        public DepartmentRepository(ProjectDbContext dbContext):base(dbContext) 
        {
            
        }

    }
}
