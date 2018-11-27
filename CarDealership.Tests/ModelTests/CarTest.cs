using System;
using CarDealership.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CarDealership.Tests.ModelTests
{
    [TestClass]
    public class CarTest
    {
        [TestMethod]
        public void DoesClassInstantiate_Instantiation_NewObj()
        {
            Car testCar = new Car();
        }
    }
}
