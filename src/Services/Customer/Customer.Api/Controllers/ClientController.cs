using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Customer.Service.EventHandlers.Commands;
using Customer.Service.Queries;
using Customer.Service.Queries.DTOs;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Service.Common.Collection;

namespace Customer.Api.Controllers
{
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    [Route("v1/clients")]
    public class ClientController : ControllerBase
    {
        private readonly ILogger<ClientController> _logger;
        private readonly IClientQueryService _clients;
        private readonly IMediator _mediator;

        public ClientController(ILogger<ClientController> logger,IClientQueryService clients, IMediator mediator)
        {
            _logger = logger;
            _clients = clients;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<DataCollection<ClientDto>> GetAll(int page = 1, int take = 10, string ids = null) 
        {
            IEnumerable<int> clients = null;

            if (!string.IsNullOrEmpty(ids)) 
            {
                clients = ids.Split(',').Select(x => Convert.ToInt32(x));
            }

            return await _clients.GetAllAsync(page, take, clients);
        }


        [HttpGet("{id}")]
        public async Task<ClientDto> Get(int id)
        {
            return await _clients.GetAsync(id);
        }

        [HttpPost]
        public async Task<ActionResult> Create(ClientCreateCommand command)
        {
            await _mediator.Publish(command);
            return Ok();
        }
    }
}
