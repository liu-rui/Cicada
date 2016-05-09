using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cicada;
using Cicada.Boot.Service;
using Cicada.Log;
using Cicada.Mq;

namespace ServiceDemo
{
    public class Service : IService
    {
        private static readonly ILog Log = CicadaFacade.CreateLog<Service>();

        private readonly IReceiverManager _receiverManager;
        public Service(IReceiverManager receiverManager)
        {
            _receiverManager = receiverManager;
        }

        /// <summary>
        /// 当服务启动时执行此方法
        /// </summary>
        public void Start()
        {
            Log.Info("start");
            _receiverManager.Run();
        }

        /// <summary>
        /// 当服务停止时执行此方法
        /// </summary>
        public void Stop()
        {
            Log.Info("stop");
            _receiverManager.Close();
        }
    }
}
