using System;
using Bll.Dtos;
using Bll.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cicada.DI;

namespace Bll.Test
{
    [TestClass]
    public class CustomerServiceWithDbTest
    {
        [TestMethod]
        public void TestAdd()
        {
            var customerService = Cicada.CicadaFacade.Container.Resolve<ICustomerService>();
            var customer = new CustomerPostParam { Name = "张三1", Phone = "18610170816" };
            var ret = customerService.Add(customer);

            Assert.IsNotNull(ret); 
        }
    }
}
