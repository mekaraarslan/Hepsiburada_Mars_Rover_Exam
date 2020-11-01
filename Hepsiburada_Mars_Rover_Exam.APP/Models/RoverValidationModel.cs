using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hepsiburada_Mars_Rover_Exam.APP.Models
{
    public class RoverValidationModel
    {
        public bool isValid { get; set; }
        public List<string> Messages { get; set; }
    }
}
