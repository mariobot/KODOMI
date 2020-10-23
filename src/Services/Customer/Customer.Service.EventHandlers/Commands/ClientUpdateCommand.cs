using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Customer.Service.EventHandlers.Commands
{
    public class ClientUpdateCommand : INotification
    {
        public int IdClient { get; set; }
        public string Name { get; set; }
    }
}
