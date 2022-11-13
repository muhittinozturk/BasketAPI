using Application.Abstract;
using Application.Features.Basket.Commands.AddBasketItem;
using MediatR;

namespace Application.PersonOperation.Commands.AddBasketItem
{
    public class AddBasketItemCommandHandler : IRequestHandler<AddBasketItemCommandRequest, AddBasketItemCommandResponse>
    {
        private readonly IBasketItemService _basketItemService;

        public AddBasketItemCommandHandler(IBasketItemService basketItemService)
        {
            _basketItemService = basketItemService;
        }

        public async Task<AddBasketItemCommandResponse> Handle(AddBasketItemCommandRequest request, CancellationToken cancellationToken)
        {
            var result = await _basketItemService.AddItemToBasket(new CreateBasketItemDto
            {
                ProductId = request.ProductId,
                Quantity = request.Quantity
            });
            if (result)
            {
                await _basketItemService.SaveAsync();
                return new()
                {
                    IsSuccess = true
                };
            }
            else
            {
                return new()
                {
                    IsSuccess = false
                };
            }

        }
    }
}
