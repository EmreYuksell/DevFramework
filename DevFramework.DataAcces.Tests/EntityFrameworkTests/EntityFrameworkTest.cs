using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DevFramework.DataAcces.Northwind.EntityFramework;

namespace DevFramework.DataAcces.Tests.EntityFrameworkTests
{
    [TestClass]
    public class EntityFrameworkTest
    {
        [TestMethod]
        public void Get_all_returns_all_products()
        {
            EfProductDal productDal = new EfProductDal();

            var result = productDal.GetList();

            Assert.AreEqual(82, result.Count);
        }
    }
}
