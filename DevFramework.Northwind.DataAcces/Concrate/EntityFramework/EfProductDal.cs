using DevFramework.Core.DataAcces.EntityFramework;
using DevFramework.Northwind.DataAcces.Abstract;
using DevFramework.Northwind.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DevFramework.Northwind.DataAcces.Concrate.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>>, IProductDal
    {


    }
}
