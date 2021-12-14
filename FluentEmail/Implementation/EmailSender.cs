using System;
using System.Collections.Generic;
using FluentEmail.Abstraction;
using System.Linq;

namespace FluentEmail.Implementation
{
    public class EmailSender : IEmailSender
    {
        private readonly IRepository _repository;
        private readonly IEmailBuilder _emailBuilder;
        private readonly IEmailService _emailService;

        public EmailSender(IRepository repository, IEmailBuilder emailBuilder, IEmailService emailService)
        {
            _repository = repository;
            _emailBuilder = emailBuilder;
            _emailService = emailService;
        }

        public void SendEmail()
        {
            var emailToSend = new List<string>();

            var subscribers = _repository.SubscribersToEmail();
            emailToSend.AddRange(subscribers.Select(subscriber => _emailBuilder.BuildEmail(subscriber)));

            emailToSend.ForEach(email => _emailService.SendEmail(email));  
        }
    }
}

