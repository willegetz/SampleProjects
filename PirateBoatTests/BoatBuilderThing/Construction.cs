using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatBuilderThing
{
    public class Construction
    {
        public TallShip GetClipper()
        {
            return new TallShip()
            {
                Name = "Clipper Ship",
                Masts = "3",
                Space = "200 MO"
            };
        }
    }
}
