﻿using System;
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

        //Move tests
        #region
        [TestMethod]
        public void MovingFWhileFacingNOnlyIncrementsYOnceAndStillFaceSameDirection()
        {
            var rover = new Rover();

            //Change test coordinate to accomadate wrap
            var y = rover.Y = 1;
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

            //Change test coordinate to accomadate wrap
            var y = rover.Y = 1;
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

            //Change test coordinate to accomadate wrap
            var x = rover.X = 1;
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

            //Change test coordinate to accomadate wrap
            var x = rover.X = 1;
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

            //Change test coordinate to accomadate wrap
            var y = rover.Y = 1;
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
            //Change test coordinate to accomadate wrap
            var y = rover.Y = 1;
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

            //Change test coordinate to accomadate wrap
            var x = rover.X = 1;
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

            //Change test coordinate to accomadate wrap
            var x = rover.X = 1;
            var d = rover.Direction;

            rover.Move("B", "W");

            var newX = rover.X;
            var newD = rover.Direction;

            var distance = newX - x;
            Assert.AreEqual(distance, 1);
            Assert.AreEqual(d, newD);
        }
        #endregion

        //Turn tests
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

        //World wrap tests
        #region
        [TestMethod]
        public void MovingFWhileFacingNAndAtEdgeWillResetYCoOrdinate()
        {
            var rover = new Rover();
            rover.Y = 99;
            rover.Move("F", "N");

            Assert.AreEqual(rover.Y, 0);
        }

        [TestMethod]
        public void MovingFWhileFacingEAndAtEdgeWillResetXCoOrdinate()
        {
            var rover = new Rover();
            rover.X = 99;
            rover.Move("F", "E");

            Assert.AreEqual(rover.X, 0);
        }

        [TestMethod]
        public void MovingFWhileFacingSAndAtEdgeWillSetMaxYCoOrdinate()
        {
            var rover = new Rover();
            rover.Y = 0;
            rover.Move("F", "S");

            Assert.AreEqual(rover.Y, 99);
        }

        [TestMethod]
        public void MovingFWhileFacingWAndAtEdgeWillSetMaxXCoOrdinate()
        {
            var rover = new Rover();
            rover.X = 0;
            rover.Move("F", "W");

            Assert.AreEqual(rover.X, 99);
        }

        [TestMethod]
        public void MovingBWhileFacingNAndAtEdgeWillSetMaxYCoOrdinate()
        {
            var rover = new Rover();
            rover.Y = 0;
            rover.Move("B", "N");

            Assert.AreEqual(rover.Y, 99);
        }

        [TestMethod]
        public void MovingBWhileFacingEAndAtEdgeWillSetMaxXCoOrdinate()
        {
            var rover = new Rover();
            rover.X = 0;
            rover.Move("B", "E");

            Assert.AreEqual(rover.X, 99);
        }

        [TestMethod]
        public void MovingBWhileFacingSAndAtEdgeWillResetYCoOrdinate()
        {
            var rover = new Rover();
            rover.Y = 99;
            rover.Move("B", "S");

            Assert.AreEqual(rover.Y, 0);
        }

        [TestMethod]
        public void MovingBWhileFacingWAndAtEdgeWillResetXCoOrdinate()
        {
            var rover = new Rover();
            rover.X = 99;
            rover.Move("B", "W");

            Assert.AreEqual(rover.X, 0);
        }
        #endregion

        //Obstacle detection
        #region
        [TestMethod]
        public void MovingFWhileFacingNAndAnObstacleIsInFrontWillRemainAtSameLocation()
        {
            var rover = new Rover();
            rover.X = 1;
            rover.Y = 1;

            //Set obstacle
            rover.Pluto[1, 2] = true;

            rover.Move("F", "N");
            Assert.AreEqual(rover.Y, 1);
            Assert.AreEqual(rover.LastCheckX, 1);
            Assert.AreEqual(rover.LastCheckY, 2);
        }

        [TestMethod]
        public void MovingBWhileFacingNAndAnObstacleIsBehindWillRemainAtSameLocation()
        {
            var rover = new Rover();
            rover.X = 1;
            rover.Y = 1;

            //Set obstacle
            rover.Pluto[1, 0] = true;

            rover.Move("B", "N");
            Assert.AreEqual(rover.Y, 1);
            Assert.AreEqual(rover.LastCheckX, 1);
            Assert.AreEqual(rover.LastCheckY, 0);
        }

        [TestMethod]
        public void MovingFWhileFacingEAndAnObstacleIsInFrontWillRemainAtSameLocation()
        {
            var rover = new Rover();
            rover.X = 1;
            rover.Y = 1;

            //Set obstacle
            rover.Pluto[2, 1] = true;

            rover.Move("F", "E");
            Assert.AreEqual(rover.X, 1);
            Assert.AreEqual(rover.LastCheckX, 2);
            Assert.AreEqual(rover.LastCheckY, 1);
        }

        [TestMethod]
        public void MovingBWhileFacingEAndAnObstacleIsBehindWillRemainAtSameLocation()
        {
            var rover = new Rover();
            rover.X = 1;
            rover.Y = 1;

            //Set obstacle
            rover.Pluto[0, 1] = true;

            rover.Move("B", "E");
            Assert.AreEqual(rover.X, 1);
            Assert.AreEqual(rover.LastCheckX, 0);
            Assert.AreEqual(rover.LastCheckY, 1);
        }

        [TestMethod]
        public void MovingFWhileFacingSAndAnObstacleIsInFrontWillRemainAtSameLocation()
        {
            var rover = new Rover();
            rover.X = 1;
            rover.Y = 1;

            //Set obstacle
            rover.Pluto[1, 0] = true;

            rover.Move("F", "S");
            Assert.AreEqual(rover.Y, 1);
            Assert.AreEqual(rover.LastCheckX, 1);
            Assert.AreEqual(rover.LastCheckY, 0);
        }

        [TestMethod]
        public void MovingBWhileFacingSAndAnObstacleIsBehindWillRemainAtSameLocation()
        {
            var rover = new Rover();
            rover.X = 1;
            rover.Y = 1;

            //Set obstacle
            rover.Pluto[1, 2] = true;

            rover.Move("B", "S");
            Assert.AreEqual(rover.Y, 1);
            Assert.AreEqual(rover.LastCheckX, 1);
            Assert.AreEqual(rover.LastCheckY, 2);
        }

        [TestMethod]
        public void MovingFWhileFacingWAndAnObstacleIsInFrontWillRemainAtSameLocation()
        {
            var rover = new Rover();
            rover.X = 1;
            rover.Y = 1;

            //Set obstacle
            rover.Pluto[0, 1] = true;

            rover.Move("F", "W");
            Assert.AreEqual(rover.X, 1);
            Assert.AreEqual(rover.LastCheckX, 0);
            Assert.AreEqual(rover.LastCheckY, 1);
        }

        [TestMethod]
        public void MovingBWhileFacingWAndAnObstacleIsBehindWillRemainAtSameLocation()
        {
            var rover = new Rover();
            rover.X = 1;
            rover.Y = 1;

            //Set obstacle
            rover.Pluto[2, 1] = true;

            rover.Move("B", "W");
            Assert.AreEqual(rover.X, 1);
            Assert.AreEqual(rover.LastCheckX, 2);
            Assert.AreEqual(rover.LastCheckY, 1);
        }
        #endregion

        //Multiple commands
        #region
        [TestMethod]
        public void EnteringFFRFFAtStartTakesYouToTwoTwoFacingEast()
        {
            var rover = new Rover();
            rover.X = 0;
            rover.Y = 0;
            rover.Direction = "N";

            rover.Move("FFRFF");

            Assert.AreEqual(rover.X, 2);
            Assert.AreEqual(rover.Y, 2);
            Assert.AreEqual(rover.Direction, "E");
        }
        [TestMethod]
        public void EnteringFFRFRFFLBWithObstacleStopsYouAtOneOneFacingSouth()
        {
            var rover = new Rover();
            rover.X = 0;
            rover.Y = 0;
            rover.Direction = "N";

            rover.Pluto[1, 0] = true;
            rover.Move("FFRFRFFLB");

            Assert.AreEqual(rover.X, 1);
            Assert.AreEqual(rover.Y, 1);
            Assert.AreEqual(rover.LastCheckX, 1);
            Assert.AreEqual(rover.LastCheckY, 0);
            Assert.AreEqual(rover.Direction, "S");
        }
        #endregion
    }
}
