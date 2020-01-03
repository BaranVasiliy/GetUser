using System;
using System.Collections.Generic;
using System.Text;
using FunctionMonkey.Abstractions;
using FunctionMonkey.Abstractions.Builders;
using GetUsers.Commands;
using GetUsers.Handlers;

namespace GetUsers
{
    public class FunctionAppConfiguration : IFunctionAppConfiguration
    {
        public void Build(IFunctionHostBuilder builder)
        {
            builder
                .Setup((serviceCollection, commandRegistry) =>
                {
                    commandRegistry.Register<GetUsersCommandHandlers>();
                })
                .Functions(functions => functions
                    .HttpRoute("v1/GetUsers", route => route
                        .HttpFunction<GetUsersCommand>()
                    )
                );
              
        }
    }
}
