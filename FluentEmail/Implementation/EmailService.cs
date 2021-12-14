using System;
using FluentEmail.Abstraction;
using FluentEmail.Core;
using Microsoft.AspNetCore.Mvc;

namespace FluentEmail.Implementation
{
    public class EmailService : IEmailService
    {
        private readonly IFluentEmail _email;

        public EmailService([FromServices]IFluentEmail email)
        {
            _email = email;
        }

        public void SendEmail(string emailContent)
        {
            _email.To("recipient@gmail.com")
                    .Subject("Email from .NET 5")
                    .Body(emailContent)
                    .Send();
        }
    }
}

