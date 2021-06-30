using ApiWorkshop.Core.DataAccess.EntityFramework;
using ApiWorkshop.DataAccess.Abstract;
using ApiWorkshop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiWorkshop.DataAccess.Concrete.EntityFramework.MainContext.Operations
{
    public class CustomerDA : EfEntityRepositoryBase<Customer, MainContext>, ICustomerDA
    {
    }
}
