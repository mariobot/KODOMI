using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Order.Service.EventHandlers.Commands;
using Order.Service.Queries;
using Order.Service.Queries.DTOs;
using Service.Common.Collection;

namespace Order.Api.Controllers
{
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    [Route("v1/orders")]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;
        private readonly IMediator _mediator;
        private readonly IOrderQueryService _ordersService;

        public OrderController(ILogger<OrderController> logger, IMediator mediator, IOrderQueryService orderServices)
        {
            _logger = logger;
            _mediator = mediator;
            _ordersService = orderServices;
        }

        [HttpGet]
        public async Task<DataCollection<OrderDto>> GetAll(int page = 1, int take = 10)
        {
            return await _ordersService.GetAllAsync(page, take);        
        }

        [HttpGet("{id}")]
        public async Task<OrderDto> Get(int id)
        {
            return await _ordersService.GetAsync(id);
        }

        [HttpPost]
        public async Task<ActionResult> Create(OrderCreateCommand command)
        {
            await _mediator.Publish(command);
            return Ok();
        }
    
    }
}
