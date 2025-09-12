namespace Drones
{

    public partial class Building
    {
        private int _xPos;
        private int _yPos;
        private int _width;
        private int _height;

        public Building(int xPos, int yPos, int width, int height)
        {
            this._xPos = xPos;
            this._yPos = yPos;
            this._width = width;
            this._height = height;
        }
    }
}