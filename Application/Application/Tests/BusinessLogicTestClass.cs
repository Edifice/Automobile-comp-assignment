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
            var bs = new BL.BusinessService();
            Assert.AreEqual(bs.GetCarsByVendor(1).Rows.Count, 3);
        }

        [Test]
        public void GetCarsByVendor2Test()
        {
            var bs = new BL.BusinessService();
            Assert.AreEqual(bs.GetCarsByVendor(2).Rows.Count, 2);
        }

        [Test]
        public void GetCarsByVendor3Test()
        {
            var bs = new BL.BusinessService();
            Assert.AreEqual(bs.GetCarsByVendor(3).Rows.Count, 2);
        }

        [Test]
        public void GetAllVendorTest()
        {
            var bs = new BL.BusinessService();
            Assert.AreEqual(bs.GetAllVendor().Count, 3);
        }
    }
}