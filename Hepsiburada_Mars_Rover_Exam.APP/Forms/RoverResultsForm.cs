using Hepsiburada_Mars_Rover_Exam.APP.Helpers;
using Hepsiburada_Mars_Rover_Exam.APP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hepsiburada_Mars_Rover_Exam.APP.Forms
{
    public partial class RoverResultsForm : Form
    {
        public RoverResultsForm()
        {
            InitializeComponent();
        }

        private void pboxCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RoverResultsForm_Load(object sender, EventArgs e)
        {
            if (StaticValues.RoverResultList != null)
            {
                FillRoverResultList(StaticValues.RoverResultList);
            }
        }

        private void FillRoverResultList(List<RoverResultModel> roverResultList)
        {
            dgvRoverResults.Rows.Clear();
            dgvRoverResults.Refresh();

            foreach (var roverResult in roverResultList)
            {
                var plateauGridSize = roverResult.PlateauGridSize.PlateauWidth + " " + roverResult.PlateauGridSize.PlateauHeight;
                var startingCoordinate = roverResult.Rover.StartingCoordinate_X + " " + roverResult.Rover.StartingCoordinate_Y + " " + roverResult.Rover.StartingDirection;
                var coordinateHistory = String.Empty;

                foreach (var coordinate in roverResult.CoordinateHistory)
                {
                    coordinateHistory += coordinate + Environment.NewLine;
                }

                dgvRoverResults.Rows.Add(
                    roverResult.Rover.RoverNumber.ToString(),
                    roverResult.Rover.RoverName,
                    plateauGridSize,
                    startingCoordinate,
                    roverResult.LastCoordinate,
                    coordinateHistory);
            }
        }
    }
}
