using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace FluentEmail
{
    public class Program
    {
        public static readonly System.IServiceProvider Container = new ContainerBuilder().Build();

        static void Main(string[] args)
        {
            Container.GetServices<INotifier>().ToList().ForEach(p => p.Notify());
        }
    }
}

