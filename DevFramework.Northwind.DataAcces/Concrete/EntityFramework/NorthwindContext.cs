﻿using DevFramework.Northwind.DataAccess.Concrete.EntityFramework.Mappings;
using DevFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace DevFramework.Northwind.DataAccess.Concrete.EntityFramework
{

    public class NorthwindContext:DbContext
    {

        public NorthwindContext()
        {
            Database.SetInitializer<NorthwindContext>(null);

        }
        public DbSet<Product>  Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());
        }
    }
}
