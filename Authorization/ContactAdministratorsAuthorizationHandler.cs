﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using SerpantWebApp.Models;
using System.Threading.Tasks;

namespace SerpantWebApp.Authorization
{
    public class ContactAdministratorsAuthorizationHandler
                    : AuthorizationHandler<OperationAuthorizationRequirement, Student>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, OperationAuthorizationRequirement requirement,
                                     Student resource)
        {
            if (context.User == null)
            {
                return Task.CompletedTask;
            }

            // Administrators can do anything.
            if (context.User.IsInRole(Constants.ContactAdministratorsRole))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
