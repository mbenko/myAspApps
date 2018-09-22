using System;
using System.Collections.Generic;
using System.Linq;

namespace myAspData.Models
{
    public class Customer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime CustomerSinceDt { get; set; }

        public Customer()
        {
            CustomerSinceDt = DateTime.UtcNow;
        }
    }
}