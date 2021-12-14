using System;
namespace FluentEmail.Abstraction
{
    public interface IEmailService
    {
        public void SendEmail(string emailContent);
    }
}

