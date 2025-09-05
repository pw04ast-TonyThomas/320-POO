using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parachutes
{
    public class Plane
    {
        // Position de l'avion
        public int _planeXPos;
        public List<Para> parachutists;
        private int _altitude;

        private string[] view =
        {
            @" _                         ",
            @"| \                        ",
            @"|  \       ______          ",
            @"--- \_____/  |_|_\____  |  ",
            @"  \_______ --------- __>-} ",
            @"        \_____|_____/   |  "
        };


        public Plane(int planeXPos)
        {
            this._planeXPos = planeXPos;
            _altitude = Config.SCREEN_HEIGHT;
        }


        /// <summary>
        /// Avance la position de l'avion de 1.
        /// </summary>
        public void update()
        {
            _planeXPos += 1;
        }

        /// <summary>
        /// Print l'avion à sa position actuelle.
        /// </summary>
        public void draw() {
            for (int i = 0; i < view.Length; i++)
            {
                Console.SetCursorPosition(_planeXPos, i + 2);
                Console.Write(view[i]);
            }
        }

        public void Board(Para para)
        {
            this.parachutists.Add(para);
        }

        public Para DropParachutist()
        {
            Para parachutist = parachutists.First();
            parachutists.Remove(parachutist);
            parachutist._parachutistXPos = _planeXPos;
            parachutist._altitude = this._altitude;
            return parachutist;
        }
    }
}
