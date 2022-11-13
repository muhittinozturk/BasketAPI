using Application.Abstract;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.PersonOperation.Commands.DeleteItem
{
    public class DeleteBasketItemCommandHandler : IRequestHandler<DeleteBasketItemCommandRequest, DeleteBasketItemCommandResponse>
    {
        private readonly IBasketItemService _basketItemService;

        public DeleteBasketItemCommandHandler(IBasketItemService basketItemService)
        {
            _basketItemService = basketItemService;
        }

        public async Task<DeleteBasketItemCommandResponse> Handle(DeleteBasketItemCommandRequest request, CancellationToken cancellationToken)
        {
            await _basketItemService.DeleteAsync(request.Id);
            await _basketItemService.SaveAsync();
            return new DeleteBasketItemCommandResponse();
        }
    }
}
