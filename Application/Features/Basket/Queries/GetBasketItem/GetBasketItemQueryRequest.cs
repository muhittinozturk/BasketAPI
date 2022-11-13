using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.PersonOperation.Queries.GetBasketItem
{
    public class GetBasketItemQueryRequest : IRequest<List<GetBasketItemQueryResponse>>
    {
    }
}
