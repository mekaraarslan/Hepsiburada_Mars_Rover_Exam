using Hepsiburada_Mars_Rover_Exam.APP.Models;
using System.Collections.Generic;

namespace Hepsiburada_Mars_Rover_Exam.APP.Helpers
{
    public static class StaticValues
    {
        public static PlateauGridSizeModel PlateauGridSize { get; set; }
        public static List<RoverModel> RoverList = new List<RoverModel>();
        public static List<RoverResultModel> RoverResultList = new List<RoverResultModel>();
    }
}
