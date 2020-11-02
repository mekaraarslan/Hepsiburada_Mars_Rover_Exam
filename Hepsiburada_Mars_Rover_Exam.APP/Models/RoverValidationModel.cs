using System.Collections.Generic;

namespace Hepsiburada_Mars_Rover_Exam.APP.Models
{
    public class RoverValidationModel
    {
        public bool isValid { get; set; }
        public List<string> Messages { get; set; }
    }
}
