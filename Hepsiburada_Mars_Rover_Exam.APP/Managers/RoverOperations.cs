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
        public string PositionRover(PlateauGridSizeModel plateauGridSize, RoverModel rover)
        {
            if (plateauGridSize != null && rover != null)
            {
                // 5-5 bir array için 6-6 değer girilir index numaraları eşit olması amacıyla
                string[,] plateauGrid = new string[plateauGridSize.PlateauHeight + 1, plateauGridSize.PlateauWidth + 1];
                string roverDirection = rover.StartingDirection.ToString();
                string roverText = rover.RoverNumber + "-" + rover.RoverName + "-" + roverDirection;

                plateauGrid[rover.StartingCoordinate_Y, rover.StartingCoordinate_X] = roverText;


                for (int i = 0; i < rover.RedirectCommands.Length; i++)
                {
                    if (rover.RedirectCommands[i].ToString().Equals("L"))
                    {
                        roverDirection = RotateRover(roverDirection, "L");
                        RoverRotateSet(ref plateauGrid, roverText, (rover.RoverNumber + "-" + rover.RoverName + "-" + roverDirection));
                    }
                    else if (rover.RedirectCommands[i].ToString().Equals("M"))
                    {
                        RoverMove(ref plateauGrid, roverDirection, roverText);
                    }
                    else if (rover.RedirectCommands[i].ToString().Equals("R"))
                    {
                        roverDirection = RotateRover(roverDirection, "R");
                        RoverRotateSet(ref plateauGrid, roverText, (rover.RoverNumber + "-" + rover.RoverName + "-" + roverDirection));
                    }

                    roverText = rover.RoverNumber + "-" + rover.RoverName + "-" + roverDirection;
                }

                string roverLastCoordinate = RoverGetLastCoordinate(plateauGrid, roverText);

                return roverLastCoordinate + " " + roverDirection;
            }
            else
                return null;
        }

        private void RoverMove(ref string[,] plateauGrid, string roverDirection, string roverText)
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

            plateauGrid[roverCoordinate_Y, roverCoordinate_X] = roverText;

        }

        private string RoverGetLastCoordinate(string[,] plateauGrid, string roverText)
        {
            for (int i = 0; i < plateauGrid.GetLength(0); i++)
            {
                for (int j = 0; j < plateauGrid.GetLength(1); j++)
                {
                    if (plateauGrid[i, j] != null)
                    {
                        if (plateauGrid[i, j].ToString().Equals(roverText))
                        {
                            return j + " " + i;
                        }
                    }
                }
            }
            return null;
        }

        private string RotateRover(string direction, string command)
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

        private void RoverRotateSet(ref string[,] plateauGrid, string roverText, string newRoverText)
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

        private void MaxGridSizeCalculate(PlateauGridSizeModel plateauGridSize, RoverModel rover)
        {
            string direction = rover.StartingDirection.ToString();
            int coordinate_Y = 0, coordinate_X = 0;
            int coordinate_negative_Y = 0, coordinate_negative_X = 0;

            for (int i = 0; i < rover.RedirectCommands.Length; i++)
            {
                if (rover.RedirectCommands[i].Equals("R"))
                {
                    direction = RotateRover(direction, "R");
                }
                else if (rover.RedirectCommands[i].Equals("M"))
                {
                    if (direction.Equals("N"))
                    {
                        if (coordinate_Y >= plateauGridSize.PlateauHeight)
                        {
                            coordinate_negative_Y++;
                        }
                        else
                        {
                            coordinate_Y++;
                        }
                    }
                    else if (direction.Equals("S"))
                    {
                        coordinate_Y--;
                    }
                    else if (direction.Equals("W"))
                    {
                        if (coordinate_X >= plateauGridSize.PlateauWidth)
                        {
                            coordinate_negative_X++;
                        }
                        else
                        {
                            coordinate_X--;
                        }
                        
                    }
                    else if (direction.Equals("E"))
                    {
                        if (coordinate_X >= plateauGridSize.PlateauWidth)
                        {
                            coordinate_negative_X++;
                        }
                        else
                        {
                            coordinate_X++;
                        }
                    }
                }
                else if (rover.RedirectCommands[i].Equals("L"))
                {
                    direction = RotateRover(direction, "L");
                }
            }


        }


    }
}
