using ApiWorkshop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiWorkshop.Business.Abstract
{
    public interface ICustomerService
    {
        public List<Customer> GetList();
    }
}
