using FluentEmail.Abstraction;

namespace FluentEmail
{
    public class Notifier : INotifier
    {
        private readonly IEmailSender _emailSender;

        public Notifier(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public void Notify()
        {
            _emailSender.SendEmail();
        }
    }
}

