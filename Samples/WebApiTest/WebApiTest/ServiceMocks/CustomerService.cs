using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bll.Dtos;
using Bll.Services;

namespace WebApiTest.ServiceMocks
{
    public class CustomerService : ICustomerService
    {
        public Cicada.Core.Ret<IList<Bll.Dtos.CustomerRet>> Get()
        {
            return new Cicada.Core.Ret<IList<Bll.Dtos.CustomerRet>>
            {
                Data = new List<CustomerRet>
                {
                      new CustomerRet   {  Id = 1 , Name = "张三" , Phone = "123465789"},
                      new CustomerRet   {  Id = 1 , Name = "李四" , Phone = "1234657890"},
                      new CustomerRet   {  Id = 1 , Name = "孙武" , Phone = "12346578901"},
                }
            };
        }

        public Cicada.Core.Ret<int> Add(Bll.Dtos.CustomerPostParam item)
        {
            if (item == null || string.IsNullOrWhiteSpace(item.Name)) return new Cicada.Core.Ret<int> { Status = 1 , Message = "用户名无效"};
            if (string.IsNullOrWhiteSpace(item.Phone) ) return new Cicada.Core.Ret<int> { Status = 2, Message = "手机号无效" };

            return new Cicada.Core.Ret<int>();
        }
    }
}