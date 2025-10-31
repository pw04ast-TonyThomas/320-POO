using static System.Net.Mime.MediaTypeNames;
using System.Text;
using System.Net.WebSockets;

namespace Boat
{
    public class Boat : IBoat
    {
        public string Name { get; }

        public float MaxCargoWeight { get; }

        public int MaxSpeed { get; }

        public List<Container> Containers = new List<Container>();

        public Boat(string name, float maxCargoWeight, int maxSpeed)
        {
            this.Name = name;
            this.MaxCargoWeight = maxCargoWeight;
            this.MaxSpeed = maxSpeed;
        }

        public bool LoadContainer(IContainer container)
        {
            try
            {
                Containers.Add((Container)container);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Start()
        {
            Console.WriteLine("Started the boat or sum");
        }

        public bool UnloadContainer(IContainer container)
        {
            try
            {
                Containers.Remove((Container)container);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}