using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
	public class CustomerConfiguration
	{
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("CustomerID").IsRequired();
            builder.Property(b => b.CompanyName).HasColumnName("CompanyName").IsRequired(); ;
            builder.Property(b => b.ContactName).HasColumnName("ContactName");
            builder.Property(b => b.City).HasColumnName("City");
            builder.Property(b => b.Country).HasColumnName("Country");

            builder.HasIndex(indexExpression: b => b.CompanyName, name: "UK_Customer_CompanyName").IsUnique();
            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}

