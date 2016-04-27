using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Bll.Dtos;
using Bll.Models;
using Cicada.Data.EntityFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bll.ServiceImpls;
using Moq;

namespace Bll.Test
{
    [TestClass]
    public class CustomerServiceTest
    {
        [TestMethod]
        public void TestGet()
        {
            var customers = new List<Customer>
            {
                 new Customer{ CustomerId = 1, Name = "张三" , Phone = "1234" },
                 new Customer {CustomerId = 1, Name = "李四", Phone = "12345"},
                 new Customer {CustomerId = 1, Name = "苏武", Phone = "123456"},
            };
            var customerQueryable = customers.AsQueryable();
            var dbContext = new Mock<IDbContext>();
            var customerSet = new Mock<DbSet<Customer>>();
            customerSet.As<IQueryable<Customer>>().Setup(w => w.Provider).Returns(customerQueryable.Provider);
            customerSet.As<IQueryable<Customer>>().Setup(w => w.Expression).Returns(customerQueryable.Expression);
            customerSet.As<IQueryable<Customer>>().Setup(w => w.ElementType).Returns(customerQueryable.ElementType);
            customerSet.As<IQueryable<Customer>>().Setup(w => w.GetEnumerator()).Returns(customerQueryable.GetEnumerator());

            dbContext.Setup(w => w.Set<Customer>()).Returns(customerSet.Object);

            var customerService = new CustomerService(dbContext.Object);

            var ret = customerService.Get();
            Assert.IsNotNull(ret);

            for (int i = 0; i < customers.Count; i++)
            {
                Assert.IsTrue(Equals(customers[i], ret.Data[i]));
            }
        }

        private bool Equals(Customer first, CustomerRet second)
        {
            return first.CustomerId == second.Id && first.Name == second.Name && first.Phone == second.Phone;
        }


        [TestMethod]
        public void TestAdd()
        {
            var customerService = new CustomerService(null);

            var ret = customerService.Add(null);

            Assert.AreEqual(1, ret.Status);
            Assert.AreEqual("用户名无效", ret.Message);

            ret = customerService.Add(new CustomerPostParam { });

            Assert.AreEqual(1, ret.Status);
            Assert.AreEqual("用户名无效", ret.Message);

            ret = customerService.Add(new CustomerPostParam { Name = "    " });

            Assert.AreEqual(1, ret.Status);
            Assert.AreEqual("用户名无效", ret.Message);


            ret = customerService.Add(new CustomerPostParam { Name = "张宁三", Phone = null });

            Assert.AreEqual(2, ret.Status);
            Assert.AreEqual("手机号无效", ret.Message);

            ret = customerService.Add(new CustomerPostParam { Name = "张宁三", Phone = "" });

            Assert.AreEqual(2, ret.Status);
            Assert.AreEqual("手机号无效", ret.Message);

            ret = customerService.Add(new CustomerPostParam { Name = "张宁三", Phone = "12" });

            Assert.AreEqual(2, ret.Status);
            Assert.AreEqual("手机号无效", ret.Message);

            ret = customerService.Add(new CustomerPostParam { Name = "张宁三", Phone = "186101780816" });

            Assert.AreEqual(2, ret.Status);
            Assert.AreEqual("手机号无效", ret.Message);
        }

        [TestMethod]
        public void TestAdd_ExistsName()
        {
            var customers = new List<Customer>
            {
                 new Customer{ CustomerId = 1, Name = "张三" , Phone = "1234" },
                 new Customer {CustomerId = 1, Name = "李四", Phone = "12345"},
                 new Customer {CustomerId = 1, Name = "苏武", Phone = "123456"},
            };
            var customerQueryable = customers.AsQueryable();
            var dbContext = new Mock<IDbContext>();
            var customerSet = new Mock<DbSet<Customer>>();
            customerSet.As<IQueryable<Customer>>().Setup(w => w.Provider).Returns(customerQueryable.Provider);
            customerSet.As<IQueryable<Customer>>().Setup(w => w.Expression).Returns(customerQueryable.Expression);
            customerSet.As<IQueryable<Customer>>().Setup(w => w.ElementType).Returns(customerQueryable.ElementType);
            customerSet.As<IQueryable<Customer>>().Setup(w => w.GetEnumerator()).Returns(customerQueryable.GetEnumerator());

            dbContext.Setup(w => w.Set<Customer>()).Returns(customerSet.Object);

            var customerService = new CustomerService(dbContext.Object);
            var ret = customerService.Add(new CustomerPostParam { Name = "张三", Phone = "18610178081" });

            Assert.AreEqual(3, ret.Status);
            Assert.AreEqual("用户名已存在", ret.Message);
        }
    }
}
