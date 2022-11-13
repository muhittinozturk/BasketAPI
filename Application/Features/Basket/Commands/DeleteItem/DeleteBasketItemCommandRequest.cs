using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.PersonOperation.Commands.DeleteItem
{
    public class DeleteBasketItemCommandRequest : IRequest<DeleteBasketItemCommandResponse>
    {
        public Guid Id { get; set; }
    }
}
