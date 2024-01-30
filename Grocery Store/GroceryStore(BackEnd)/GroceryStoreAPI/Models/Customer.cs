﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreAPI.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FullName { get; set; }
        public string EmailId { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public bool Isadmin { get; set; }
    }
}
