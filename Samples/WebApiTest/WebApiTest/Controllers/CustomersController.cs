using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Bll.Dtos;
using Bll.Services;
using Cicada.Core;

namespace WebApiTest.Controllers
{
    public class CustomersController : ApiController
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public Ret<IList<CustomerRet>> Get()
        {
            return _customerService.Get();
        }


        public Ret<int> Post(CustomerPostParam  item)
        {
            return _customerService.Add(item);
        }
    }
}
