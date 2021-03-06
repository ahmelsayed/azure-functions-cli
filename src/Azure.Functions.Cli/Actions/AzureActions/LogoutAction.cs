﻿using System;
using System.Threading.Tasks;
using Azure.Functions.Cli.Arm;

namespace Azure.Functions.Cli.Actions.AzureActions
{
    [Action(Name = "logout", Context = Context.Azure, HelpText = "Log out of Azure account")]
    class LogoutAction : BaseAction
    {
        private readonly IArmManager _armManager;

        public LogoutAction(IArmManager armManager)
        {
            _armManager = armManager;
        }

        public override Task RunAsync()
        {
            _armManager.Logout();
            return Task.CompletedTask;
        }
    }
}
