﻿using System;
using System.Linq.Expressions;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories").HasKey(b => b.Id);
            builder.Property(b => b.Id ).HasColumnName("CategoryId").IsRequired(); builder.Property(b => b.Name ).HasColumnName("CategoryName").IsRequired();
            builder.HasIndex(indexExpression: b => b.Name , name: "UK_Categories_Name").IsUnique();
            builder.HasMany(b => b.Products);
            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}

