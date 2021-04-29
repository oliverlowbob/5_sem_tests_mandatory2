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
            Serializer ser = new Serializer();
            string path = string.Empty;
            string xmlInputData = string.Empty;
            string xmlOutputData = string.Empty;

            string workingDirectory = Environment.CurrentDirectory;
            path = Directory.GetParent(workingDirectory).Parent.Parent.FullName + @"\Delivery.xml";

            xmlInputData = File.ReadAllText(path);

            DeliveryInfo deliveryInfo = ser.Deserialize<DeliveryInfo>(xmlInputData);

            Assert.AreEqual("50", deliveryInfo.DeliveryId);
            Assert.AreEqual("50", deliveryInfo.DeliveryId);
        }
    }
}