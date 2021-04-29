using NUnit.Framework;
using System;
using System.Xml;

namespace PhoneCompany
{
    public class XmlTest
    {
        string path = Environment.CurrentDirectory;

        XmlDocument delivery = new XmlDocument();

        XmlDocument order = new XmlDocument();

        XmlDocument storage = new XmlDocument();

        [SetUp]
        public void Setup()
        {
            delivery.Load(path + "Delivery.xml");
            delivery.Load(path + "Order.xml");
            delivery.Load(path + "Storage.xml");

        }

        [Test]
        public void TestDeliveryId()
        {
            Assert.AreEqual(50, delivery.GetElementById("DeliveryId"));
        }
    }
}