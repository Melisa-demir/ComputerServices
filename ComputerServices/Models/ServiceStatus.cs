using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerServices.Models
{
    public class ServiceStatus:BaseEntity
    {
        public string StatusName { get; set; }
        public string Description { get; set; }
    }
}
