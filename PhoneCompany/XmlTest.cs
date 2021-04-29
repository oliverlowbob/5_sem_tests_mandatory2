using NUnit.Framework;
using System;
using System.IO;
using System.Xml;

namespace PhoneCompany
{
    public class XmlTest
    {
        XmlDocument delivery = new XmlDocument();



        [SetUp]
        public void Setup()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string path = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

            delivery.Load(path + @"\Delivery.xml");
        }

        [Test]
        public void TestDeliveryId()
        {
            var element = delivery.GetElementsByTagName("DeliveryId");

            Assert.AreEqual("50", element.Item(0).InnerText);
        }
    }
}