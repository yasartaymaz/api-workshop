using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiWorkshop.Core.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime DatetimeInserted { get; set; }
        public DateTime DatetimeUpdated { get; set; }
    }
}
