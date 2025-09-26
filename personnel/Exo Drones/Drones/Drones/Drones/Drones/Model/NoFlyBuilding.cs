using System.Drawing.Text;

namespace Drones
{
    public partial class NoFlyBuilding : Building
    {
        private static string _color = "Red";

        public NoFlyBuilding(int xPos, int yPos, int width, int height) : base(xPos, yPos, width, height)
        {

        }
    }
}