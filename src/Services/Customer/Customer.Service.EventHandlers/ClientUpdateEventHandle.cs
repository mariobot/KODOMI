using Customer.Persistence.Database;
using Customer.Service.EventHandlers.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Customer.Service.EventHandlers
{
    public class ClientUpdateEventHandle : INotificationHandler<ClientUpdateCommand>
    {
        private readonly ApplicationDbContext applicationDbContext;

        public ClientUpdateEventHandle(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public async Task Handle(ClientUpdateCommand command, CancellationToken token)
        {
            var client = applicationDbContext.Clients.FirstOrDefault(x => x.ClientId == command.IdClient);
            client.Name = command.Name;
            applicationDbContext.Update(client);
            await applicationDbContext.SaveChangesAsync();
        }
    }
}
