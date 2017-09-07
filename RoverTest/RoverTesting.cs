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
    }
}
