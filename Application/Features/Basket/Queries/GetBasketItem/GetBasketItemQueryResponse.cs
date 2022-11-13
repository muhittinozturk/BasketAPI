using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.PersonOperation.Queries.GetBasketItem
{
    public class GetBasketItemQueryResponse
    {
        public string? Name { get; set; }
        public int Quantity { get; set; }
    }
}
