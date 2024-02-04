using DevFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace DevFramework.Northwind.DataAccess.Concrete.EntityFramework.Mappings
{
    public class ProductMap:EntityTypeConfiguration<Product>
    {

        public ProductMap()
        {
            ToTable(@"Product", @"dbo");
            HasKey(x => x.ProductId);

            Property(x => x.ProductId).HasColumnName("ProductId");
            Property(x => x.CategoryId).HasColumnName("ProductId");
            Property(x => x.ProductName).HasColumnName("ProductId");
            Property(x => x.QuantityPerUnit).HasColumnName("ProductId");
            Property(x => x.UnitPrice).HasColumnName("ProductId");

        }

    }
}
