using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernateDemo.Models;
using NUnit.Framework;
using NHibernate.Linq;

namespace NHibernateDemo.TestCases
{
    [TestFixture]
    public class ProductTest : TestBase
    {
        [TestFixtureTearDown]
        public void Cleanup()
        {
            Session.Flush();
            Transaction.Commit();
            Session.Dispose();
        }

        [Test]
        public void 正确查询数据()
        {
            if (Session.Query<Product>().Any() == false)
            {
                正确添加数据();
            }
            var products = Session.Query<Product>().ToList();
            Assert.True(products.Count >= 0);
            foreach (var product in products)
            {
                const string formater = "Name => {0}, Price => {1}";
                Console.WriteLine(formater, product.Name, product.Price.ToString("N"));
            }
        }

        [Test]
        public void 正确添加数据()
        {
            var newProduct = new Product
            {
                Price = 4500,
                Name = "IPhone5"
            };
            var id = (int)Session.Save(newProduct);
            Assert.True(id > 0);
        }

        [Test]
        public void 正确更新数据()
        {
            var product = Session.Query<Product>().FirstOrDefault();
            Assert.NotNull(product);
            product.Price = product.Price + 1;
            Session.Flush();
            var newProduct = Session.Get<Product>(product.Id);
            Assert.True((product.Price - newProduct.Price) < 0.01);
        }
    }
}