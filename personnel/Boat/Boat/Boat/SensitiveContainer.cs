using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boat
{
    public class SensitiveContainer : Container
    {
        public SensitiveContainer(int id, float weight,  string color, bool isRefrigerated = false) : base(id, weight, isRefrigerated, color)
        {

        }
    }
}
