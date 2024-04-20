using Microsoft.EntityFrameworkCore;
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
    public class GenericRepository<T>:IGenericRepository<T> where T : class  // SET => Is Class فباكد ان اللي هييجي هيكون class 
    {
        private readonly ProjectDbContext dbContext;

        public GenericRepository(ProjectDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task Add(T item)
          => await dbContext.Set<T>().AddAsync(item);
           
       

        public void Delete(T item)
          => dbContext.Set<T>().Remove(item);
            
        
        public void Update(T item)
           => dbContext.Set<T>().Update(item);
           

        public async Task<T> Get(int id)
           => await dbContext.FindAsync<T>(id); //Find = Search in local if not found so Search in Remote
        
        
        public async Task<IEnumerable<T>> GetAll()
             => await dbContext.Set<T>().ToListAsync();
        

    }
}
