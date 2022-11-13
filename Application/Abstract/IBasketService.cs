using Domain.Entities;
using Domain.Entities.Common;

namespace Application.Abstract
{
    public interface IBasketService : IBaseService<Basket>
    {
        Task<List<BasketItem>> GetBasketItemAsync();

    }
}
