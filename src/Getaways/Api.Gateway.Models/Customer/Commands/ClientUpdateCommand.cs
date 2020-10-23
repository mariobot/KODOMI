using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Gateway.Models.Customer.Commands
{
    public class ClientUpdateCommand
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
    }
}
