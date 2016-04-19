using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bll.Dtos;
using Cicada.Core;

namespace Bll.Services
{
    public interface ICustomerService
    {
        Ret<IList<CustomerRet>> Get();


        Ret<int> Add(CustomerPostParam item);
    }
}
