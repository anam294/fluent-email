using System;
using System.Collections.Generic;
using FluentEmail.Abstraction;

namespace FluentEmail.Implementation
{
    public class Repository : IRepository
    {
        public List<string> SubscribersToEmail()
        {
            return new List<string>
            {
                "Email@gmail.com",
                "Test@hotmail.com"
            };
        }
    }
}

