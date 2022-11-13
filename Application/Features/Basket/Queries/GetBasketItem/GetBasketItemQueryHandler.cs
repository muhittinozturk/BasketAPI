using Application.Abstract;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Application.PersonOperation.Queries.GetBasketItem
{
    public class GetBasketItemQueryHandler : IRequestHandler<GetBasketItemQueryRequest, List<GetBasketItemQueryResponse>>
    {
        private readonly IBasketService _basketService;

        public GetBasketItemQueryHandler(IBasketService basketService)
        {
            _basketService = basketService;
        }
        public async Task<List<GetBasketItemQueryResponse>> Handle(GetBasketItemQueryRequest request, CancellationToken cancellationToken)
        {
            List<BasketItem> basketItems = await _basketService.GetBasketItemAsync();

            return basketItems.Select(b => new GetBasketItemQueryResponse
            {
                Name = b.Product.ProductName,
                Quantity = b.Quantity
            }).ToList();
        }
    }
}
