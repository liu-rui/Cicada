using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cicada;
using Cicada.Boot.Service;
using Cicada.Log;

namespace ServiceDemo
{
    public class Service : IService
    {
        private static readonly ILog Log = CicadaFacade.CreateLog<Service>();

        /// <summary>
        /// 当服务启动时执行此方法
        /// </summary>
        public void Start()
        {
            Log.Info("start");
        }

        /// <summary>
        /// 当服务停止时执行此方法
        /// </summary>
        public void Stop()
        {
            Log.Info("stop");
        }
    }
}
