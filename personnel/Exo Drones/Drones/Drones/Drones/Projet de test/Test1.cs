using Drones;
using Drones.Interfaces;

namespace Projet_de_test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void Test_that_drone_is_taking_orders()
        {
            // Arrange
            Drone drone = new Drone(500, 500);

            // Act
            EvacuationState state = drone.GetEvacuationState();

            // Assert
            Assert.AreEqual(EvacuationState.Free, state);

            // Arrange a no-fly zone around the drone
            bool response = drone.Evacuate(new System.Drawing.Rectangle(400, 400, 200, 200));

            // Assert
            Assert.IsFalse(response); // because the zone is around the drone
            Assert.AreEqual(EvacuationState.Evacuating, drone.GetEvacuationState());

            // Arrange: remove no-fly zone
            drone.FreeFlight();

            // Assert
            Assert.AreEqual(EvacuationState.Free, drone.GetEvacuationState());

            // Arrange a no-fly zone away from the drone
            response = drone.Evacuate(new System.Drawing.Rectangle(700, 700, 200, 200));

            // Assert
            Assert.IsTrue(response); // because the zone is away from the drone
            Assert.AreEqual(EvacuationState.Evacuated, drone.GetEvacuationState());

        }
    }
}
