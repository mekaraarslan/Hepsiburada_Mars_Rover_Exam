using Hepsiburada_Mars_Rover_Exam.APP.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hepsiburada_Mars_Rover_Exam.APP.Models
{
    public class RoverModel
    {
        public int RoverNumber { get; set; }
        public string RoverName { get; set; }
        public int StartingCoordinate_X { get; set; }
        public int StartingCoordinate_Y { get; set; }
        public char StartingDirection { get; set; }
        public string RedirectCommands { get; set; }
    }
}
