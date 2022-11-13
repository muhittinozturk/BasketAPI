using Application.PersonOperation.Commands.AddBasketItem;
using Application.PersonOperation.Queries.GetBasketItem;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        IMediator _mediator;

        public BasketController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get(GetBasketItemQueryRequest request)
        {
            List<GetBasketItemQueryResponse> response = await _mediator.Send(request);

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddBasketItemCommandRequest request)
        {
            var result = await _mediator.Send(request);

            return result.IsSuccess ? StatusCode((int)HttpStatusCode.Created) : BadRequest();
        }


    }
}
