using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boat
{
    public class TankContainer : Container
    {
        public TankContainer(int id, float weight,  string color, bool isRefrigerated = true) : base(id, weight, isRefrigerated, color)
        {

        }
    }
}
