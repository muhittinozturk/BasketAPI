using Application.Features.Basket.Commands.AddBasketItem;
using Domain.Entities;
using Domain.Entities.Common;

namespace Application.Abstract
{
    public interface IBasketItemService : IBaseService<BasketItem>
    {
        Task<bool> AddItemToBasket(CreateBasketItemDto createBasketItemDto);

    }
}
