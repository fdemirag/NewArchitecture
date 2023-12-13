using System;
using Core.Entities;

namespace Entities
{
	public class Customer:Entity<string>
	{
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}

