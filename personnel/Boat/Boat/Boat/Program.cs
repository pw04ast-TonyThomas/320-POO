using static System.Net.Mime.MediaTypeNames;
using System.Text;
using System.ComponentModel;

namespace Drones
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        static void Main()
        {
            List<Boat.Boat> boats = new List<Boat.Boat>();

            Boat.Boat boat1 = new Boat.Boat("leSkibidi", 40, 350);
            boats.Add(boat1);
            Boat.Boat boat2 = new Boat.Boat("leGillian", 60, 250);
            boats.Add(boat2);
            Boat.Boat boat3 = new Boat.Boat("Orienter#", 30, 200);
            boats.Add(boat3);

            foreach (var boat in boats)
            {
                boat.Start();
                boat.LoadContainer(new Boat.RefrigeratedContainer(1, 20, "Blue"));
                boat.LoadContainer(new Boat.TankContainer(2, 40, "Green"));
                boat.LoadContainer(new Boat.SensitiveContainer(3, 30, "Red"));

                int index = 0;

                foreach (var container in boat.Containers)
                {
                    Console.WriteLine(boat.Containers[index]);
                    index++;
                }
            }
        }
    }
}