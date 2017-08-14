using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatBuilderThing
{
    public class ShipYard
    {
        public SailingShip GetClipper()
        {
            return new SailingShip()
            {
                Name = "Clipper Ship",
                Masts = "3",
                Space = "200 MO"
            };
        }
    }
}
