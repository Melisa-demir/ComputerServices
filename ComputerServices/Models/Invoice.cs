using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerServices.Models
{
    public class Invoice :BaseEntity
    {
        public int ServiceId { get; set; }
        [ForeignKey("ServiceId")]
        public virtual ServiceRecord ServiceRecord { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
