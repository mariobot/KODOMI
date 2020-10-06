﻿using Identity.Domain;
using Identity.Service.EventHandlers.Commands;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System.Threading;
using System.Threading.Tasks;

namespace Identity.Service.EventHandlers
{
    public class UserCreateEventHandler : IRequestHandler<UserCreateCommand, IdentityResult>
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UserCreateEventHandler(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        
        public async Task<IdentityResult> Handle(UserCreateCommand command, CancellationToken token)
        {
            var entity = new ApplicationUser()
            {
                FirstName = command.FirstName,
                SecondName = command.SecondName,
                Email = command.Email,
                UserName = command.Email,
            };

            return await _userManager.CreateAsync(entity, command.Password);
        }
    }
}
