using System.Drawing.Text;

namespace Drones
{
    public partial class Factory : Building
    {
        private static string factoryColor = "Red";
        private float _powerConsumption;

        public Factory(float PowerConsumption, int xPos, int yPos, int width, int height) : base(xPos, yPos, width, height)
        {
            this._powerConsumption = PowerConsumption;
            Console.WriteLine($"this factory consumes : {_powerConsumption}");
        }
    }
}