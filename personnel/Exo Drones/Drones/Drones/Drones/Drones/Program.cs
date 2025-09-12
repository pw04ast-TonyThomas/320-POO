using Drones.Helpers;
using System.Security.Cryptography.X509Certificates;

namespace Drones
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            int nbOfBuildings = RandomHelper.random.Next(5, 50);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Création de la flotte de drones
            List<Drone> fleet= new List<Drone>();
            Drone drone = new Drone();
            drone.X = 100;
            drone.Y = 100;
            drone.Name = "Joe";
            fleet.Add(drone);

            // Création de la liste de batiments
            List<Building> buildings = new List<Building>();
            for (int i = 0; i < nbOfBuildings ; i++)
            {
                Building building = new Building(RandomHelper.random.Next(1, AirSpace.WIDTH), RandomHelper.random.Next(1, AirSpace.HEIGHT), RandomHelper.random.Next(20, 200), RandomHelper.random.Next(20, 100));
                buildings.Add(building);
            }

            // Démarrage
            Application.Run(new AirSpace(fleet, buildings));
        }
    }
}