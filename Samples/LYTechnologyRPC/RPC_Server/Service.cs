using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cicada;
using Cicada.Boot.Service;
using Cicada.Log;
using Cicada.Rpc.Server;

namespace ServiceDemo
{
    public class Service : IService
    {
        private static readonly ILog Log = CicadaFacade.CreateLog<Service>();
       
        private readonly IRpcServer _rpcServer;

        public Service(IRpcServer  rpcServer)
        {
            _rpcServer = rpcServer;
        }

        /// <summary>
        /// 当服务启动时执行此方法
        /// </summary>
        public void Start()
        {
            Log.Info("start");
            _rpcServer.Run<ThriftCustomerService.Iface>();
        }

        /// <summary>   
        /// 当服务停止时执行此方法
        /// </summary>
        public void Stop()
        {
            _rpcServer.Close();
            Log.Info("stop");
        }
    }
}
