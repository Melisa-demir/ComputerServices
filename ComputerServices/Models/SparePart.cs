using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerServices.Models
{
    public class SparePart:BaseEntity
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int StockQuantity { get; set; }
        public decimal Price { get; set; }
    }
}
