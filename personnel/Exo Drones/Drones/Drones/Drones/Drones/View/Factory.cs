using System.Drawing.Text;

namespace Drones
{
    public partial class Factory : Building
    {
        private SolidBrush buildingBrush = new SolidBrush(Color.FromName(factoryColor));

        // De manière graphique
        public new void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.FillRectangle(buildingBrush, new Rectangle(_xPos, _yPos, _width, _height));
            // drawingSpace.Graphics.DrawString($"{this}", TextHelpers.drawFont, TextHelpers.writingBrush, X + 5, Y - 5);
        }
    }
}