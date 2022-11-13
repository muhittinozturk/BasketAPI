using Application.Abstract;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;
using System.Linq.Expressions;

namespace Persistence.Concrete
{
    public class ProductManager : BaseManager<Product>, IProductService
    {
        private readonly ApplicationDbContext _context;
        public ProductManager(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }


        public async Task<bool> InStockAsync(Expression<Func<Product, bool>> method)
        {
            return await Table.FirstOrDefaultAsync(method) == null ? false : true;
            
        }
    }
}
