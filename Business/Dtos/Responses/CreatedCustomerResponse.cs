using System;
namespace Business.Dtos.Responses
{
	public class CreatedCustomerResponse
	{
        public string CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}

