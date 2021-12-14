using System;
using System.Collections.Generic;

namespace FluentEmail.Abstraction
{
    public interface IRepository
    {
        public List<string> SubscribersToEmail();
    }
}

