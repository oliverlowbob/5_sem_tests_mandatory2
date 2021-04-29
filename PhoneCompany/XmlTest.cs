using NUnit.Framework;
using PhoneCompany.Model;
using System;
using System.IO;
using System.Xml;

namespace PhoneCompany
{
    public class XmlTest
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestDeliveryId()
        {
            XmlDocument deliveryXml = new XmlDocument();

            Serializer ser = new Serializer();

            var workingDirectory = Environment.CurrentDirectory;

            var path = Directory.GetParent(workingDirectory).Parent.Parent.FullName + @"\Delivery.xml";

            deliveryXml.Load(path);

            var xmlInputData = File.ReadAllText(path);

            DeliveryInfo deliveryInfo = ser.Deserialize<DeliveryInfo>(xmlInputData);

            var element = deliveryXml.GetElementsByTagName("DeliveryId");

            Assert.AreEqual(element.Item(0).InnerText, deliveryInfo.DeliveryId);
        }

        [Test]
        public void TestDeliveryInfoCustomer()
        {
            XmlDocument deliveryXml = new XmlDocument();

            Serializer ser = new Serializer();

            var workingDirectory = Environment.CurrentDirectory;

            var path = Directory.GetParent(workingDirectory).Parent.Parent.FullName + @"\Delivery.xml";

            deliveryXml.Load(path);

            var xmlInputData = File.ReadAllText(path);

            DeliveryInfo deliveryInfo = ser.Deserialize<DeliveryInfo>(xmlInputData);

            var element = deliveryXml.GetElementsByTagName("Customer");

            Assert.AreEqual(element.Item(0).FirstChild.InnerText, deliveryInfo.Customer.Name);
        }
    }
}