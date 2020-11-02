using Hepsiburada_Mars_Rover_Exam.APP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hepsiburada_Mars_Rover_Exam.APP.Managers
{
    public class RoverOperations
    {
        public RoverResultModel PositionRover(PlateauGridSizeModel plateauGridSize, RoverModel rover)
        {
            if (plateauGridSize != null && rover != null)
            {
                var maxGridSize = MaxGridSizeCalculate(plateauGridSize, rover);
                string[,] plateauGrid =
                    new string[maxGridSize.South + maxGridSize.North + plateauGridSize.PlateauHeight + 1, maxGridSize.West + maxGridSize.East + plateauGridSize.PlateauWidth + 1];
                List<string> coordinateHistory = new List<string>();
                string roverDirection = rover.StartingDirection.ToString();
                string roverText = rover.RoverNumber + "-" + rover.RoverName + "-" + roverDirection;

                coordinateHistory.Add(rover.StartingCoordinate_X + " " + rover.StartingCoordinate_Y + " " + rover.StartingDirection);
                plateauGrid[rover.StartingCoordinate_Y + maxGridSize.South, rover.StartingCoordinate_X + maxGridSize.West] = roverText;


                for (int i = 0; i < rover.RedirectCommands.Length; i++)
                {
                    if (rover.RedirectCommands[i].ToString().Equals("L"))
                    {
                        roverDirection = RotateRover(roverDirection, "L");
                        RoverRotateSet(ref plateauGrid, roverText, (rover.RoverNumber + "-" + rover.RoverName + "-" + roverDirection));
                    }
                    else if (rover.RedirectCommands[i].ToString().Equals("M"))
                    {
                        RoverMove(ref plateauGrid, ref coordinateHistory, maxGridSize, roverDirection, roverText, plateauGridSize);
                    }
                    else if (rover.RedirectCommands[i].ToString().Equals("R"))
                    {
                        roverDirection = RotateRover(roverDirection, "R");
                        RoverRotateSet(ref plateauGrid, roverText, (rover.RoverNumber + "-" + rover.RoverName + "-" + roverDirection));
                    }

                    roverText = rover.RoverNumber + "-" + rover.RoverName + "-" + roverDirection;
                }

                string roverLastCoordinate = RoverGetLastCoordinate(plateauGrid, roverText, maxGridSize);

                return new RoverResultModel()
                {
                    LastCoordinate = roverLastCoordinate + " " + roverDirection,
                    CoordinateHistory = coordinateHistory,
                    Rover = rover,
                    PlateauGridSize = plateauGridSize
                };
            }
            else
                return null;
        }

        public void RoverMove(ref string[,] plateauGrid, ref List<string> coordinateHistory, PlateauMaxGridSizeModel plateauMaxGridSize, string roverDirection, string roverText, PlateauGridSizeModel plateauGridSize)
        {
            int roverCoordinate_X = 0;
            int roverCoordinate_Y = 0;

            for (int i = 0; i < plateauGrid.GetLength(0); i++)
            {
                for (int j = 0; j < plateauGrid.GetLength(1); j++)
                {
                    if (plateauGrid[i, j] != null)
                    {
                        if (plateauGrid[i, j].ToString().Equals(roverText))
                        {
                            roverCoordinate_X = j;
                            roverCoordinate_Y = i;
                            plateauGrid[i, j] = "-" + roverText.Split('-')[0] + "-";
                        }
                    }
                }
            }

            if (roverDirection.Equals("N"))
                roverCoordinate_Y++;
            else if (roverDirection.Equals("E"))
                roverCoordinate_X++;
            else if (roverDirection.Equals("S"))
                roverCoordinate_Y--;
            else if (roverDirection.Equals("W"))
                roverCoordinate_X--;

            string offThePlateau = " - (Off the plateau!)";
            string coordinate = (roverCoordinate_X - plateauMaxGridSize.West) + " " + (roverCoordinate_Y - plateauMaxGridSize.South).ToString() + " " + roverDirection;

            if (roverCoordinate_Y - plateauMaxGridSize.South <= 0 
                || roverCoordinate_X - plateauMaxGridSize.West <= 0
                || roverCoordinate_Y - plateauMaxGridSize.North > plateauGridSize.PlateauHeight
                || roverCoordinate_X - plateauMaxGridSize.East > plateauGridSize.PlateauWidth)
            {
                coordinate += offThePlateau;
            }

            coordinateHistory.Add(coordinate);
            plateauGrid[roverCoordinate_Y, roverCoordinate_X] = roverText;

        }

        public string RoverGetLastCoordinate(string[,] plateauGrid, string roverText, PlateauMaxGridSizeModel plateauMaxGrid)
        {
            for (int i = 0; i < plateauGrid.GetLength(0); i++)
            {
                for (int j = 0; j < plateauGrid.GetLength(1); j++)
                {
                    if (plateauGrid[i, j] != null)
                    {
                        if (plateauGrid[i, j].ToString().Equals(roverText))
                        {
                            return (j - plateauMaxGrid.West).ToString() + " " + (i - plateauMaxGrid.South).ToString();
                        }
                    }
                }
            }
            return null;
        }

        public string RotateRover(string direction, string command)
        {
            List<char> rotates = new List<char> { 'S', 'W', 'N', 'E' };

            int rotateIndex = rotates.FindIndex(x => x.ToString() == direction);

            if (command.Equals("L"))
            {
                if (rotateIndex == 0)
                    return rotates[rotates.Count - 1].ToString();
                else
                    return rotates[rotateIndex - 1].ToString();
            }
            else if (command.Equals("R"))
            {
                if (rotateIndex == rotates.Count - 1)
                    return rotates[0].ToString();
                else
                    return rotates[rotateIndex + 1].ToString();
            }
            else
                return null;
        }

        public void RoverRotateSet(ref string[,] plateauGrid, string roverText, string newRoverText)
        {
            for (int i = 0; i < plateauGrid.GetLength(0); i++)
            {
                for (int j = 0; j < plateauGrid.GetLength(1); j++)
                {
                    if (plateauGrid[i, j] != null)
                    {
                        if (plateauGrid[i, j].ToString().Equals(roverText))
                        {
                            plateauGrid[i, j] = newRoverText;
                        }
                    }
                }
            }
        }

        public PlateauMaxGridSizeModel MaxGridSizeCalculate(PlateauGridSizeModel plateauGridSize, RoverModel rover)
        {
            string direction = rover.StartingDirection.ToString();
            int north = 0, south = 0, east = 0, west = 0;

            for (int i = 0; i < rover.RedirectCommands.Length; i++)
            {
                if (rover.RedirectCommands[i].ToString().Equals("R"))
                {
                    direction = RotateRover(direction, "R");
                }
                else if (rover.RedirectCommands[i].ToString().Equals("M"))
                {
                    if (direction.Equals("N")) //Y
                    {
                        north++;
                    }
                    else if (direction.Equals("S"))  //Y
                    {
                        south++;
                    }
                    else if (direction.Equals("W"))  //X
                    {
                        west++;
                    }
                    else if (direction.Equals("E"))  //X
                    {
                        east++;
                    }
                }
                else if (rover.RedirectCommands[i].ToString().Equals("L"))
                {
                    direction = RotateRover(direction, "L");
                }
            }

            return new PlateauMaxGridSizeModel()
            {
                East = east,
                North = north,
                South = south,
                West = west
            };

        }


    }
}
