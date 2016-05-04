using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cicada.Boot.Service;

namespace RPC_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceApplication.Run();

            Console.Read();
        }
    }
}
