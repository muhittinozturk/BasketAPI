using Domain.Entities;
using Domain.Entities.Common;
using System.Linq.Expressions;

namespace Application.Abstract
{
    public interface IProductService : IBaseService<Product>
    {
        Task<bool> InStockAsync(Expression<Func<Product, bool>> method);

    }
}
