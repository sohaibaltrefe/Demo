using Demo.BLL.Interfaces;
using Demo.DAL.Data;
using Demo.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext dbContext;

        public ProductRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public int Add(Product product)
        {
dbContext.Products.Add(product);
            return dbContext.SaveChanges();
        }

        public int Delete(Product product)
        {
            dbContext.Products.Remove(product);
            return dbContext.SaveChanges();
        }

        public IEnumerable<Product> GetAll()
        {
return dbContext.Products.AsNoTracking().ToList();
                }

        public Product Get(int id)
        {
            return dbContext.Products.Find(id);
        }

        public int Update(Product product)
        {
            dbContext.Products.Update(product);
            return dbContext.SaveChanges();
        }
        public void save( )
        {
            dbContext.SaveChanges();
           
        }
    }
}
