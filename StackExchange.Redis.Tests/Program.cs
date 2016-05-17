#if NUNITLITE
using System;
using System.Reflection;
using NUnit.Common;
using NUnitLite;

namespace StackExchange.Redis.Tests
{
    public class Program
    {
        public int Main(string[] args)
        {
            var writer = new ExtendedTextWrapper(Console.Out);
            return new AutoRun(typeof(TestBase).GetTypeInfo().Assembly).Execute(args, writer, Console.In);
        }
    }
}
#endif