﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerServices.Models
{
    public class Customer:BaseEntity
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }

    }
}
