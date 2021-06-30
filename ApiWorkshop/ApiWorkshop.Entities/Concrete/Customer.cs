using ApiWorkshop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiWorkshop.Entities.Concrete
{
    public class Customer : Entity, IEntity
    {
        public string Name { get; set; }
    }
}
