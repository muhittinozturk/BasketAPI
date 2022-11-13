using Application.Common;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Basket.Commands.AddBasketItem
{
    public class CreateBasketItemDto : IMapFrom<BasketItem>
    {
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
