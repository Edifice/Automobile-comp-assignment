using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NUnit.Framework;

namespace Application.Tests
{
    [TestFixture]
    public class BusinessLogicTestClass
    {
        [Test]
        public void GetCarsByVendor1Test()
        {
            var bs = new Application.AutomobileServiceReference.BusinessServiceClient();
            Assert.AreEqual(bs.GetAutomobiles().Count(a => a.vendorId == 1), 3);
        }

        [Test]
        public void GetCarsByVendor2Test()
        {
            var bs = new Application.AutomobileServiceReference.BusinessServiceClient();
            Assert.AreEqual(bs.GetAutomobiles().Count(a => a.vendorId == 2), 2);
        }

        [Test]
        public void GetCarsByVendor3Test()
        {
            var bs = new Application.AutomobileServiceReference.BusinessServiceClient();
            Assert.AreEqual(bs.GetAutomobiles().Count(a => a.vendorId == 3), 2);
        }

        [Test]
        public void GetAllVendorTest()
        {
            var bs = new Application.AutomobileServiceReference.BusinessServiceClient();
            Assert.AreEqual(bs.GetAllVendors().Count(), 3);
        }
    }
}