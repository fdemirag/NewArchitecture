﻿

using Core.Entities;

namespace Entities.Concretes;

public class Product  : Entity<int>
{
    public int CategoryId { get; set; }
    public string ProductName { get; set; }
    public decimal UnitPrice { get; set; }
    public short UnitsInStock { get; set; }
    public string QuantityPerUnit { get; set; }
    public Category Category { get; set; }
}