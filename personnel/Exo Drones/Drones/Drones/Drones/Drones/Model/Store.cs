using System.Drawing.Text;

namespace Drones
{
    public partial class Store : Building
    {
        private string _openingHours;
        private static string _storeColor = "Blue";

        public Store(string OpeningHours, int xPos, int yPos, int width, int height) : base(xPos, yPos, width, height)
        {
            this._openingHours = OpeningHours;
            Console.WriteLine($"this factory consumes : {_openingHours}");
        }
    }
}