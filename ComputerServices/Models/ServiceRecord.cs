using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerServices.Models
{
    public class ServiceRecord:BaseEntity
    {
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
        public string DeviceType { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public string IssueDescription { get; set; }
        public DateTime AccceptanceDate { get; set; }
        public DateTime EstimatedCompletionDate { get; set; }
        public int StatusId { get; set; }
        [ForeignKey("StatusId")]
        public ServiceRecord Status { get; set; } 
    }
}
