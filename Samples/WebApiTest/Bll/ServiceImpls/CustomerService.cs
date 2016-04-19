using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bll.Dtos;
using Bll.Models;
using Bll.Services;
using Cicada.Core;
using Cicada.Data.EntityFramework;
using System.Linq;

namespace Bll.ServiceImpls
{
    public class CustomerService : ICustomerService
    {
        private readonly IDbContext _dbContext;

        public CustomerService(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Cicada.Core.Ret<IList<Dtos.CustomerRet>> Get()
        {
            var a = 10;
            var b = 0;
            var c = a / b;

            var customerSet = _dbContext.Set<Customer>();
            var data = customerSet.ToList();

            return new Ret<IList<Dtos.CustomerRet>>
            {
                Data = data.Select(w => new CustomerRet { Id = w.CustomerId, Name = w.Name, Phone = w.Phone }).ToList(),
            };
        }

        public Cicada.Core.Ret<int> Add(Dtos.CustomerPostParam item)
        {
            if (item == null || string.IsNullOrWhiteSpace(item.Name)) return new Cicada.Core.Ret<int> { Status = 1, Message = "用户名无效" };

            if (string.IsNullOrWhiteSpace(item.Phone) || !StringUtil.IsPhone(item.Phone)) return new Cicada.Core.Ret<int> { Status = 2, Message = "手机号无效" };

            var newCustomer = new Customer
            {
                Name = item.Name.Trim(),
                Phone = item.Phone,
            };
            

            if (_dbContext.Set<Customer>().FirstOrDefault(w => w.Name == item.Name) != null) return new Ret<int> { Status = 3, Message = "用户名已存在" };

            _dbContext.Set<Customer>().Add(newCustomer);
            _dbContext.SaveChanges();
            return new Ret<int> { Data = newCustomer .CustomerId};
        }
    }
}
