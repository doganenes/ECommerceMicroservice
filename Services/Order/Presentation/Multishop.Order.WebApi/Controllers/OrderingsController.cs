using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Multishop.Order.Application.Features.Mediator.Commands.OrderingCommands;
using Multishop.Order.Application.Features.Mediator.Queries.OrderingQueries;

namespace Multishop.Order.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderingsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderingsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> OrderingList()
        {

            var result = await _mediator.Send(new GetOrderingQuery());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderingById(int id)
        {
            var values = await _mediator.Send(new GetOrderingByIdQuery(id));
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrdering(CreateOrderingCommand command)
        {
            await _mediator.Send(command);
            return Ok("Add ordering successfully!");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateOrdering(UpdateOrderingCommand command)
        {
            await _mediator.Send(command);
            return Ok("Update ordering successfully!");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveOrdering(int id)
        {
            await _mediator.Send(new RemoveOrderingCommand(id));
            return Ok("Remove ordering successfully!");
        }

    }
}