using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cicada;
using Cicada.Boot;
using Cicada.DI;

namespace RPC_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            CicadaApplication.Run();

            while (true)
            {
                var customerService = CicadaFacade.Container.Resolve<ThriftCustomerService.Iface>();

                var id = customerService.Add(new Customer
                    {
                        Name = "张三",
                        AddressInfo = new Address { City = "北京", Street = "朝阳" }
                    });

                Console.WriteLine(customerService.Get(id));

                Console.WriteLine();
                Console.WriteLine("getlist");
                var customers = customerService.GetList();

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer);
                }

                Console.WriteLine();
                Console.WriteLine("getmap");
                var customerMap = customerService.GetMap();

                foreach (var customer in customerMap)
                {
                    Console.WriteLine("Key:{0} Value:{1}", customer.Key, customer.Value);
                }

                Thread.Sleep(500);
            }

            Console.Read();
        }
    }
}
