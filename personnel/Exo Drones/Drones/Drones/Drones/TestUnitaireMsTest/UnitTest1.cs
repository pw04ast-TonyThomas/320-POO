using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using 
namespace TestUnitaireMsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            for (int i = 0; i < 10; i++)
            {
                Drone drone = new Drone();
                drone.X = 100;
                drone.Y = RandomHelper.random.Next(100, 500);
                drone.Name = "Joe";
                fleet.Add(drone);
            }
        }
    }
}
