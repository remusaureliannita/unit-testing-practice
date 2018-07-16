using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    public class ProductTests
    {
        [Test]
        public void GetPrice_GoldCustomer_ApplyDiscount()
        {
            var product = new Product {ListPrice = 100};

            var result = product.GetPrice(new Customer {IsGold = true});

            Assert.That(result, Is.EqualTo(70));
        }
        
    }
}
