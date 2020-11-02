using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hepsiburada_Mars_Rover_Exam.APP.Models
{
    public class RoverResultModel
    {
        public string LastCoordinate { get; set; }
        public List<string> CoordinateHistory { get; set; }
        public RoverModel Rover { get; set; }
        public PlateauGridSizeModel PlateauGridSize { get; set; }
    }
}
