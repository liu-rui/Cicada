using System.Collections.Generic;
using System.Linq;
using Cicada;
using Cicada.Log;


    public class CustomerService : ThriftCustomerService.Iface
    {
        private static ILog Log = CicadaFacade.CreateLog<CustomerService>();
        private Dictionary<int, Customer> _customers = new Dictionary<int, Customer>();

        public int Add(Customer customer)
        {
            Log.Info("add");
            if (customer == null) return -1;
            var id = _customers.Count + 1;

            customer.CustomerId = id;
            _customers.Add(id, customer);
            return id;
        }

        public Customer Get(int id)
        {
            Log.Info("get");
            return  _customers.ContainsKey(id) ?   _customers[id] : null;
        }

        public List<Customer> GetList()
        {
            Log.Info("getlist");
            return _customers.Values.ToList();
        }

        public Dictionary<int, Customer> GetMap()
        {
            Log.Info("getmap");
            return _customers;
        }
    }

