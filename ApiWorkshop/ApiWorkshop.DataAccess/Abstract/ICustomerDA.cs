using ApiWorkshop.Core.DataAccess;
using ApiWorkshop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiWorkshop.DataAccess.Abstract
{
    public interface ICustomerDA : IEntityRepository<Customer>
    {
    }
}
