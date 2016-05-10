using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cicada;
using Cicada.Boot;
using Cicada.Mq;
using Cicada.DI;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            CicadaApplication.Run();
            var i = 0;

            while (true)
            {
                var sender = CicadaFacade.Container.Resolve<ISender>();

                sender.Send("OrderChannel", i++);
                Thread.Sleep(500);

                Console.ReadLine();
            }
        }
    }
}
