﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NewPatientMonitor;

namespace NewPatientMonitorTest
{
    [TestClass()]
    public class TestBay
    {
        [TestMethod()]
        public void TestAddBedSideMonitor()
        {
            IBay testBay = new Bay();
            testBay.AddBedSideMonitor();

            Assert.IsNotNull(testBay.Beds[0]);
        }

        [TestMethod()]
        public void TestRemoveBedsideMonitor()
        {
            IBay testBay = new Bay(2);
            testBay.RemoveBedsideMonitor(0);

            Assert.AreEqual(1, testBay.Beds.Count);
            
        }
    }
}