using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.Model
{
    public class Box
    {
        public static int id;
        public int personnalId;
        private int _kg;
        private string _color;
        public string color { get { return _color; } set {_color = value; } }
        public static string[] colorArray = { "Rouge", "Jaune", "Bleu", "Brun", "Orange" };

        public Box(int kg, string color)
        {
            id++;
            personnalId = id;
            this._kg = kg;
            this._color = color;
        }
    }
}
