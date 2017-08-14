using ApprovalTests;
using ApprovalTests.Reporters;
using BoatBuilderThing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatTests
{
    [TestClass]
    [UseReporter(typeof(VisualStudioReporter))]
    public class BoatTests
    {
        [TestMethod]
        public void TestGetABoat()
        {
            // arrange
            // Instantiate the ship factory
            var shipyard = new ShipYard();
            // act
            // Get a clipper ship
            var clipperShip = shipyard.GetClipper();
            // assert
            // Verify you have a clipper ship
            Approvals.Verify(clipperShip);
        }
    }
}
