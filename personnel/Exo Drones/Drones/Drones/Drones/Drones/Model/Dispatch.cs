using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.Model
{
    public class Dispatch : IDispatchable
    {
        public static List<Box> droppedBoxes = new List<Box>();

        public void DropBox(Box box)
        {
            droppedBoxes.Add(box);
            Console.WriteLine($"Recieved box: {box.personnalId}");
        }

        public Box? Pickup()
        {
            if (droppedBoxes.Count == 0)
            {
                return null;
            }
            else
            {
                foreach (Box box in droppedBoxes)
                {
                    droppedBoxes.Remove(box);
                    return box;
                }
                return null;
            }
        }
    }
}
