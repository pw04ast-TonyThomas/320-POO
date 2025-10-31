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
                boat.LoadContainer(new Container());
            }
        }
    }
}