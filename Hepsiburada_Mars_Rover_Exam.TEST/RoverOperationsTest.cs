using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hepsiburada_Mars_Rover_Exam.APP.Models;
using Hepsiburada_Mars_Rover_Exam.APP.Managers;

namespace Hepsiburada_Mars_Rover_Exam.TEST
{
    [TestClass]
    public class RoverOperationsTest
    {
        private RoverOperations _roverOperations = null;

        public RoverOperationsTest()
        {
            _roverOperations = new RoverOperations();
        }

        [TestMethod]
        public void MaxGridSizeCalculate_PlateauAndRoverInformationGiven_DirectionIsExpected()
        {
            PlateauGridSizeModel plateauGridSize = new PlateauGridSizeModel()
            {
                PlateauHeight = 5,
                PlateauWidth = 5
            };

            RoverModel rover = new RoverModel()
            {
                RoverNumber = 1,
                RoverName = "MEKRS",
                StartingDirection = 'N',
                StartingCoordinate_X = 1,
                StartingCoordinate_Y = 2,
                RedirectCommands = "LMLMLMLMM"
            };

            PlateauMaxGridSizeModel plateauMaxGridSize_Actual = _roverOperations.MaxGridSizeCalculate(plateauGridSize, rover);

            PlateauMaxGridSizeModel plateauMaxGridSize_Expected = new PlateauMaxGridSizeModel()
            {
                East = 1,
                North = 2,
                South = 1,
                West = 1
            };

            Assert.AreEqual(plateauMaxGridSize_Expected.East, plateauMaxGridSize_Actual.East);
            Assert.AreEqual(plateauMaxGridSize_Expected.North, plateauMaxGridSize_Actual.North);
            Assert.AreEqual(plateauMaxGridSize_Expected.West, plateauMaxGridSize_Actual.West);
            Assert.AreEqual(plateauMaxGridSize_Expected.South, plateauMaxGridSize_Actual.South);


        }

        [TestMethod]
        public void RoverRotateSet_PlataGridAndRoverTextAndNewRoveTextWereGiven_PlateausNewLocationIsExpected()
        {
            string[,] plateauGrid = new string[9, 8];
            string roverText = "1-MEKRS-N";
            string newRoverText = "1-MEKRS-W";

            plateauGrid[3, 2] = roverText;
            _roverOperations.RoverRotateSet(ref plateauGrid, roverText, newRoverText);

            Assert.AreEqual("1-MEKRS-W", plateauGrid[3, 2].ToString());
        }

        [TestMethod]
        public void RotateRover_DirectionAndCommandGiven_NewDirectionExpected()
        {
            var newDirection1 = _roverOperations.RotateRover("N", "L");
            var newDirection2 = _roverOperations.RotateRover("N", "R");
            var newDirection3 = _roverOperations.RotateRover("S", "L");
            var newDirection4 = _roverOperations.RotateRover("S", "R");

            Assert.AreEqual("W", newDirection1);
            Assert.AreEqual("E", newDirection2);
            Assert.AreEqual("E", newDirection3);
            Assert.AreEqual("W", newDirection4);
        }

        [TestMethod]
        public void RoverGetLastCoordinate_RequiredParametersAreGiven_TheLastLocationIsExpected()
        {
            string[,] plateauGrid = new string[9, 8];
            string roverText = "1-MEKRS-N";
            PlateauMaxGridSizeModel plateauMaxGridSize = new PlateauMaxGridSizeModel()
            {
                East = 1,
                North = 2,
                South = 1,
                West = 1
            };

            plateauGrid[4, 2] = roverText;

            var result = _roverOperations.RoverGetLastCoordinate(plateauGrid, roverText, plateauMaxGridSize);

            Assert.AreEqual("1 3", result);
        }

        [TestMethod]
        public void RoverMove_RequiredParametersAreGiven_ExpectedNewLocationAndCoordinateHistoryInTheGrid()
        {
            string[,] plateauGrid = new string[9, 8];
            plateauGrid[3, 2] = "1-MEKRS-W";
            List<string> coordinateHistory = new List<string>() { "1 2 N" };
            PlateauMaxGridSizeModel plateauMaxGridSize = new PlateauMaxGridSizeModel()
            {
                East = 1,
                North = 2,
                South = 1,
                West = 1
            };
            PlateauGridSizeModel plateauGridSize = new PlateauGridSizeModel()
            {
                PlateauHeight = 5,
                PlateauWidth = 5
            };
            string roverDirection = "W";
            string roverText = "1-MEKRS-W";

            _roverOperations.RoverMove(ref plateauGrid, ref coordinateHistory, plateauMaxGridSize, roverDirection, roverText, plateauGridSize);

            Assert.AreEqual("1 2 N", coordinateHistory[0]);
            Assert.AreEqual("0 2 W - (Off the plateau!)", coordinateHistory[1]);
            Assert.AreEqual("1-MEKRS-W", plateauGrid[3, 1].ToString());
        }

        [TestMethod]
        public void PositionRover_PlateauGridSizeAndRoverInformationWereGiven_ExpectedRoverResult()
        {
            PlateauGridSizeModel plateauGridSize = new PlateauGridSizeModel()
            {
                PlateauHeight = 5,
                PlateauWidth = 5
            };

            RoverModel rover = new RoverModel()
            {
                RoverNumber = 1,
                RoverName = "MEKRS",
                StartingDirection = 'N',
                StartingCoordinate_X = 1,
                StartingCoordinate_Y = 2,
                RedirectCommands = "LMLMLMLMM"
            };

            RoverResultModel roverResult = _roverOperations.PositionRover(plateauGridSize, rover);

            Assert.AreEqual("1 3 N", roverResult.LastCoordinate);
            Assert.AreEqual(6, roverResult.CoordinateHistory.Count);

            Assert.AreEqual("1 2 N", roverResult.CoordinateHistory[0]);
            Assert.AreEqual("0 2 W - (Off the plateau!)", roverResult.CoordinateHistory[1]);
            Assert.AreEqual("0 1 S - (Off the plateau!)", roverResult.CoordinateHistory[2]);
            Assert.AreEqual("1 1 E", roverResult.CoordinateHistory[3]);
            Assert.AreEqual("1 2 N", roverResult.CoordinateHistory[4]);
            Assert.AreEqual("1 3 N", roverResult.CoordinateHistory[5]);
        }

    }
}
