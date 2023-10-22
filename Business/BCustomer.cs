using Data;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BCustomer
    {
        public List<Customer> GetAllCustomers()
        {
            DCustomer dataCustomer = new DCustomer();
            List<Customer> allCustomers = dataCustomer.GetAll();
            return allCustomers;
        }

        public List<Customer> SearchCustomersByName(string name)
        {
            List<Customer> allCustomers = GetAllCustomers();

            List<Customer> filteredCustomers = allCustomers
                .Where(c => c.Name.Contains(name)) 
                .ToList();

            return filteredCustomers;
        }
    }
}
