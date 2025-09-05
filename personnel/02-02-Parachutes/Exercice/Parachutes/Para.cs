using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parachutes
{
    public class Para
    {
        public int _altitude;
        public string _name;
        public const int _PARA_HEIGHT = 6;
        public bool parachuteIsOpen;

        private string[] withoutParachute =
        {
         @"     ",
         @"     ",
         @"     ",
         @"  o  ",
         @" /░\ ",
         @" / \ ",
        };

        private string[] withParachute =
        {
         @" ___ ",
         @"/|||\",
         @"\   /",
         @" \o/ ",
         @"  ░  ",
         @" / \ ",
        };



        public Para() {
            this._name = Names.RandomNameGen();
        }

        public void Update()
        {
            if (_altitude > _PARA_HEIGHT)
            {
                if (parachuteIsOpen) _altitude -= 1; // décend normalement avec parachute
                else _altitude -= 3; // décente rapide sans parachute.
                if (_altitude < Config.SCREEN_HEIGHT / 2) parachuteIsOpen = true; // Ouvre le parachute au millieu de l'écran.
            }
            else parachuteIsOpen = false;
        }

        public void draw()
        {
            string[] view = !parachuteIsOpen ? withoutParachute : withParachute;

            for (int i = 0; i < view.Length; i++)
            {
                Console.SetCursorPosition(x, Config.SCREEN_HEIGHT - this._altitude + i);
                Console.Write(view[i]);
            }
            Console.SetCursorPosition(x, Config.SCREEN_HEIGHT - this._altitude - 1);
            Console.Write(this._name);


        }
    }
}
