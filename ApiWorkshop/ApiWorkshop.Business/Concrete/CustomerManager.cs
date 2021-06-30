using ApiWorkshop.Business.Abstract;
using ApiWorkshop.DataAccess.Abstract;
using ApiWorkshop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiWorkshop.Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDA _customerDA;

        public CustomerManager(ICustomerDA customerDA)
        {
            _customerDA = customerDA;
        }

        public List<Customer> GetList()
        {
            List<Customer> result = _customerDA.GetList();

            return result;
        }
    }
}
