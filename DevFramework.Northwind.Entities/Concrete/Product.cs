﻿using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevFramework.Northwind.Entities.Concrete
{
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }

        public string  QuantityPerUnit { get; set; }
        
        public decimal UnitPrice { get; set; }
    }
}
