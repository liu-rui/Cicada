using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cicada;
using Cicada.Log;
using Cicada.Mq;

namespace Server
{
    public class OrderCreateReceive : IReceiver<int>
    {
        private static readonly ILog Log = CicadaFacade.CreateLog<OrderCreateReceive>();
        public void Receive(int message)
        {
            Log.Info("开始处理 {0}", message);
            Thread.Sleep(500);
            Log.Info("结束处理 {0}", message);
        }
    }
}
