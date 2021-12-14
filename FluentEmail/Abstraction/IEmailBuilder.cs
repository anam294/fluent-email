using System;
namespace FluentEmail.Abstraction
{
    public interface IEmailBuilder
    {
        public string BuildEmail(string emailAddress);
    }
}

