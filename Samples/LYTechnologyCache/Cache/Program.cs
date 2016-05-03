using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cicada;
using Cicada.Boot;
using Cicada.Cache;
using Cicada.DI;

namespace Cache
{
    class Program
    {
        static void Main(string[] args)
        {
            CicadaApplication.Run();
            var strings = CicadaFacade.Container.Resolve<IStrings>();

            Console.WriteLine(strings.Exists("name"));
            strings.Set("name", "张三", TimeSpan.FromSeconds(5));

            Console.WriteLine(strings.Get<string>("name"));

            Console.WriteLine(strings.Exists("name"));

            Thread.Sleep(TimeSpan.FromSeconds(6));
            Console.WriteLine(strings.Get<string>("name"));
            Console.WriteLine(strings.Exists("name"));
            Console.Read();
        }
    }
}
