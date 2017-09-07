using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlutoRover;

namespace RoverTest
{
    [TestClass]
    public class RoverTesting
    {
        [TestMethod]
        public void InitialisingRover()
        {
            var rover = new Rover();
        }

        //Move Tests
        #region
        [TestMethod]
        public void MovingFWhileFacingNOnlyIncrementsYOnceAndStillFaceSameDirection()
        {
            var rover = new Rover();

            var y = rover.Y;
            var d = rover.Direction;

            rover.Move("F", "N");

            var newY = rover.Y;
            var newD = rover.Direction;

            var distance = newY - y;

            Assert.AreEqual(distance, 1);
            Assert.AreEqual(d, newD);
        }

        [TestMethod]
        public void MovingBWhileFacingNOnlyDecrementsYOnceAndStillFaceSameDirection()
        {
            var rover = new Rover();

            var y = rover.Y;
            var d = rover.Direction;
            rover.Move("B", "N");

            var newY = rover.Y;
            var newD = rover.Direction;

            var distance = newY - y;

            Assert.AreEqual(distance, -1);
            Assert.AreEqual(d, newD);
        }

        [TestMethod]
        public void MovingFWhileFacingEOnlyIncrementsXOnceAndStillFaceSameDirection()
        {
            var rover = new Rover();
            
            var x = rover.X;
            var d = rover.Direction;

            rover.Move("F", "E");

            var newX = rover.X;
            var newD = rover.Direction;

            var distance = newX - x;
            Assert.AreEqual(distance, 1);
            Assert.AreEqual(d, newD);
        }

        [TestMethod]
        public void MovingBWhileFacingEOnlyDecrementsXOnceAndStillFaceSameDirection()
        {
            var rover = new Rover();

            var x = rover.X;
            var d = rover.Direction;
            rover.Move("B", "E");

            var newX = rover.X;
            var newD = rover.Direction;

            var distance = newX - x;
            Assert.AreEqual(distance, -1);
            Assert.AreEqual(d, newD);
        }

        [TestMethod]
        public void MovingFWhileFacingSOnlyDecrementsYOnceAndStillFaceSameDirection()
        {
            var rover = new Rover();
            
            var y = rover.Y;
            var d = rover.Direction;
            rover.Move("F", "S");

            var newY = rover.Y;
            var newD = rover.Direction;

            var distance = newY - y;
            Assert.AreEqual(distance, -1);
            Assert.AreEqual(d, newD);
        }

        [TestMethod]
        public void MovingBWhileFacingSOnlyIncrementsYOnceAndStillFaceSameDirection()
        {
            var rover = new Rover();
            var y = rover.Y;
            var d = rover.Direction;
            rover.Move("B", "S");

            var newY = rover.Y;
            var newD = rover.Direction;

            var distance = newY - y;

            Assert.AreEqual(distance, 1);
            Assert.AreEqual(d, newD);
        }

        [TestMethod]
        public void MovingFWhileFacingWOnlyDecrementsXOnceAndStillFaceSameDirection()
        {
            var rover = new Rover();
            
            var x = rover.X;
            var d = rover.Direction;

            rover.Move("F", "W");

            var newX = rover.X;
            var newD = rover.Direction;

            var distance = newX - x;
            Assert.AreEqual(distance, -1);
            Assert.AreEqual(d, newD);
        }

        [TestMethod]
        public void MovingBWhileFacingWOnlyIncrementsXOnceAndStillFaceSameDirection()
        {
            var rover = new Rover();
            var x = rover.X;
            var d = rover.Direction;
            rover.Move("B", "W");

            var newX = rover.X;
            var newD = rover.Direction;

            var distance = newX - x;
            Assert.AreEqual(distance, 1);
            Assert.AreEqual(d, newD);
        }
        #endregion

        //Turn Tests
        #region
        [TestMethod]
        public void TurningLWhileFacingNChangesFacingDirectionToWAndRemainsInSameSpot()
        {
            var rover = new Rover();
            var x = rover.X;
            var y = rover.Y;
            rover.Direction = "N";
            rover.Turn("L", "N");

            var newX = rover.X;
            var newY = rover.Y;
            var newD = rover.Direction;

            Assert.AreEqual(x, newX);
            Assert.AreEqual(y, newY);
            Assert.AreEqual(newD, "W");
        }

        [TestMethod]
        public void TurningRWhileFacingNChangesFacingDirectionToEAndRemainsInSameSpot()
        {
            var rover = new Rover();
            var x = rover.X;
            var y = rover.Y;
            rover.Direction = "N";
            rover.Turn("R", "N");

            var newX = rover.X;
            var newY = rover.Y;
            var newD = rover.Direction;

            Assert.AreEqual(x, newX);
            Assert.AreEqual(y, newY);
            Assert.AreEqual(newD, "E");
        }

        [TestMethod]
        public void TurningLWhileFacingEChangesFacingDirectionToNAndRemainsInSameSpot()
        {
            var rover = new Rover();
            var x = rover.X;
            var y = rover.Y;
            rover.Direction = "E";
            rover.Turn("L", "E");

            var newX = rover.X;
            var newY = rover.Y;
            var newD = rover.Direction;

            Assert.AreEqual(x, newX);
            Assert.AreEqual(y, newY);
            Assert.AreEqual(newD, "N");
        }

        [TestMethod]
        public void TurningRWhileFacingEChangesFacingDirectionToSAndRemainsInSameSpot()
        {
            var rover = new Rover();
            var x = rover.X;
            var y = rover.Y;
            rover.Direction = "E";
            rover.Turn("R", "E");

            var newX = rover.X;
            var newY = rover.Y;
            var newD = rover.Direction;

            Assert.AreEqual(x, newX);
            Assert.AreEqual(y, newY);
            Assert.AreEqual(newD, "S");
        }

        [TestMethod]
        public void TurningLWhileFacingSChangesFacingDirectionToEAndRemainsInSameSpot()
        {
            var rover = new Rover();
            var x = rover.X;
            var y = rover.Y;
            rover.Direction = "S";
            rover.Turn("L", "S");

            var newX = rover.X;
            var newY = rover.Y;
            var newD = rover.Direction;

            Assert.AreEqual(x, newX);
            Assert.AreEqual(y, newY);
            Assert.AreEqual(newD, "E");
        }

        [TestMethod]
        public void TurningRWhileFacingSChangesFacingDirectionToWAndRemainsInSameSpot()
        {
            var rover = new Rover();
            var x = rover.X;
            var y = rover.Y;
            rover.Direction = "S";
            rover.Turn("R", "S");

            var newX = rover.X;
            var newY = rover.Y;
            var newD = rover.Direction;

            Assert.AreEqual(x, newX);
            Assert.AreEqual(y, newY);
            Assert.AreEqual(newD, "W");
        }
        [TestMethod]
        public void TurningLWhileFacingWChangesFacingDirectionToSAndRemainsInSameSpot()
        {
            var rover = new Rover();
            var x = rover.X;
            var y = rover.Y;
            rover.Direction = "W";
            rover.Turn("L", "W");

            var newX = rover.X;
            var newY = rover.Y;
            var newD = rover.Direction;

            Assert.AreEqual(x, newX);
            Assert.AreEqual(y, newY);
            Assert.AreEqual(newD, "S");
        }

        [TestMethod]
        public void TurningRWhileFacingWChangesFacingDirectionToNAndRemainsInSameSpot()
        {
            var rover = new Rover();
            var x = rover.X;
            var y = rover.Y;
            rover.Direction = "W";
            rover.Turn("R", "W");

            var newX = rover.X;
            var newY = rover.Y;
            var newD = rover.Direction;

            Assert.AreEqual(x, newX);
            Assert.AreEqual(y, newY);
            Assert.AreEqual(newD, "N");
        }
        #endregion
    }
}
