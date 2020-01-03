using System;
using System.Collections.Generic;
using System.Text;
using AzureFromTheTrenches.Commanding.Abstractions;
using GetUsers.Models;

namespace GetUsers.Commands
{
    public class GetUsersCommand: ICommand<List<User>>
    {
        public List<User> Users { get; set; }
    }
}
