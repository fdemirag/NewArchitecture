using System;
namespace Business.Dtos.Responses
{
	public class GetListProductResponse
	{
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public string QuantityPerUnit { get; set; }
    }
}

