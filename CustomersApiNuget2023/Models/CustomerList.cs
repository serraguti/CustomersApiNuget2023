﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersApiNuget2023.Models
{
    public class CustomerList
    {
        [JsonProperty("value")]
        public List<Customer> Customers { get; set; }
    }
}
