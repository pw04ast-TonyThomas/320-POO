using Drones.Helpers;
using Drones.Model;
using System.Drawing.Text;

namespace Drones
{
    public partial class Factory : Building
    {
        private static string factoryColor = "Purple";
        private float _powerConsumption;
        public static int id;
        public int personnalId;
        private List<Box> _stock = new List<Box>();
        private int _frameCounter;

        public Factory(float PowerConsumption, int xPos, int yPos, int width, int height) : base(xPos, yPos, width, height)
        {
            id++;
            personnalId = id;
            this._powerConsumption = PowerConsumption;
            Console.WriteLine($"this factory consumes : {_powerConsumption}");
        }

        public void Update(int interval)
        {
            if (interval * _frameCounter % 5000 == 0)
            {
                int randomWeight = RandomHelper.random.Next(5, 10);
                Box box = new Box(randomWeight, Box.colorArray[RandomHelper.random.Next(0, 4)]);

                Console.WriteLine($"L'usine {personnalId} a produit un carton de {randomWeight}kg de smarties {box.color}");

                _stock.Add(box);
                AirSpace.Dispatcher.DropBox(box);
            }
            _frameCounter++;
        }
    }

}