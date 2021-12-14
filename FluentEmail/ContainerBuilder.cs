using System;
using FluentEmail.Abstraction;
using FluentEmail.Implementation;
using Microsoft.Extensions.DependencyInjection;

namespace FluentEmail
{
    public class ContainerBuilder
    {
        public IServiceProvider Build()
        {
            var container = new ServiceCollection();

            // Enable SMTP from Gmail or any other SMTP server, Fill in the required parameters
            // i.e. UserName and AppPass generated.

            container.AddFluentEmail("DefaultFrom@Email.com")
                .AddRazorRenderer()
                .AddSmtpSender("smtp.gmail.com", 587, "smtpGmailUserName", "smtpGmailAppPass");

            container.AddSingleton<INotifier, Notifier>();
            container.AddSingleton<INotifier, DeNotifier>();
            container.AddSingleton<IEmailSender, EmailSender>();
            container.AddSingleton<IRepository, Repository>();
            container.AddSingleton<IEmailBuilder, EmailBuilder>();
            container.AddSingleton<IEmailService, EmailService>();

            return container.BuildServiceProvider();
        }
    }
}
