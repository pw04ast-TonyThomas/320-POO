using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parachutes
{
    public class Names
    {
        static string randomName = "";
        static int index;

        static public List<string> namesList = new List<string>
        {
            "Abigail", "Alexander", "Amelia", "Benjamin",
            "Charlotte", "Daniel", "Elizabeth", "Emily",
            "Ethan", "Grace", "Hannah", "Henry",
            "Isabella", "Jack", "James", "John",
            "Lily", "Lucas", "Madison", "Matthew",
            "Michael", "Natalie", "Noah", "Olivia",
            "Ryan", "Samantha", "Samuel", "Sarah",
            "Sophia", "Thomas", "Victoria", "William", "Zoe"
        };


        public static string RandomNameGen()
        {
            Random random = new Random();
            index = random.Next(namesList.Count);
            return namesList[index];
        }
    }
}
