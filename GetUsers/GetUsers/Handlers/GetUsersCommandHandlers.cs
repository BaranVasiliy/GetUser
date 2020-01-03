using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AzureFromTheTrenches.Commanding.Abstractions;
using GetUsers.Commands;
using GetUsers.Models;

namespace GetUsers.Handlers
{
    internal class GetUsersCommandHandlers: ICommandHandler<GetUsersCommand, List<User>>
    {
        public Task<List<User>> ExecuteAsync(GetUsersCommand command, List<User> listUsers)
        {
            if (command.Users == null)
            {
                command.Users.Add(new User() { Name = "Name", LastName = "Name" });
                return Task.FromResult(command.Users);
            }
            return Task.FromResult(command.Users);
        }
    }
}
