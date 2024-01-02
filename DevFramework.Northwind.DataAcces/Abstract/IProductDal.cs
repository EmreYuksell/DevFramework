using DevFramework.Core.DataAcces;
using DevFramework.Northwind.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevFramework.Northwind.DataAcces.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {

    }
}
