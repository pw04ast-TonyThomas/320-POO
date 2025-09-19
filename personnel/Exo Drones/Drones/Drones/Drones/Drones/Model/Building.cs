namespace Drones
{

    public partial class Building
    {
        protected int _xPos;
        protected int _yPos;
        protected int _width;
        protected int _height;

        public Building(int xPos, int yPos, int width, int height)
        {
            this._xPos = xPos;
            this._yPos = yPos;
            this._width = width;
            this._height = height;
        }
    }
}