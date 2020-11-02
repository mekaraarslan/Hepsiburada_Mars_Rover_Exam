using Hepsiburada_Mars_Rover_Exam.APP.Helpers;
using Hepsiburada_Mars_Rover_Exam.APP.Managers;
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
    public partial class TripPlanningForm : Form
    {
        public TripPlanningForm()
        {
            InitializeComponent();
        }

        private void pboxMinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pboxCloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddRover_Click(object sender, EventArgs e)
        {

            if (StaticValues.PlateauGridSize != null)
            {

                AddRoverForm addRoverForm = new AddRoverForm();
                addRoverForm.ShowDialog();

                if (StaticValues.RoverList != null)
                {
                    FillRoverList(StaticValues.RoverList);
                }
            }
            else
            {
                MessageBox.Show("Rover cannot be added without entering plateau dimensions",
                "Rover Addition Warning",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }


        }

        private void btnSavePlateauGridSize_Click(object sender, EventArgs e)
        {
            int plateauWidth = (int)nudWidthGridSize.Value;
            int plateauHeight = (int)nudHeightGridSize.Value;

            if (plateauWidth > 0 && plateauHeight > 0)
            {
                StaticValues.PlateauGridSize = new PlateauGridSizeModel()
                {
                    PlateauWidth = plateauWidth,
                    PlateauHeight = plateauHeight
                };

                MessageBox.Show("OK");

            }
            else
            {
                MessageBox.Show("Please enter valid grid size",
               "Save Grid Size Warning",
               MessageBoxButtons.OK,
               MessageBoxIcon.Warning);
            }
        }

        private void FillRoverList(List<RoverModel> roverList)
        {
            dgvRoverList.Rows.Clear();
            dgvRoverList.Refresh();

            foreach (var rover in roverList)
            {
                dgvRoverList.Rows.Add(
                    rover.RoverNumber.ToString(),
                    rover.RoverName,
                    rover.StartingDirection.ToString(),
                    rover.StartingCoordinate_X.ToString(),
                    rover.StartingCoordinate_Y.ToString(),
                    rover.RedirectCommands.ToString());
            }
        }

        private void dgvRoverList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string columnName = dgvRoverList.Columns[e.ColumnIndex].Name;

            if (columnName.Equals("roverRemove"))
            {
                var roverNo = Convert.ToInt32(dgvRoverList.Rows[e.RowIndex].Cells[0].Value);

                DialogResult dialogResult = MessageBox.Show(
                    $"Rover number {roverNo} will be deleted. Do you confirm?",
                    "Rover delete warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    var roverList = StaticValues.RoverList;
                    if (roverList != null)
                    {

                        var roverModel = roverList.Where(x => x.RoverNumber == roverNo).FirstOrDefault();

                        roverList.Remove(roverModel);
                        StaticValues.RoverList = roverList;

                        FillRoverList(roverList);
                    }
                }
            }
        }

        private void TripPlanningForm_Load(object sender, EventArgs e)
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

            StaticValues.PlateauGridSize = plateauGridSize;
            StaticValues.RoverList.Add(rover);
            FillRoverList(StaticValues.RoverList);

        }

        private void btnSendExplore_Click(object sender, EventArgs e)
        {
            bool isWarning = true;
            StaticValues.RoverResultList.Clear();

            if (dgvRoverList != null)
            {
                if (dgvRoverList.Rows.Count > 0)
                {
                    isWarning = false;
                    RoverOperations roverOperations = new RoverOperations();

                    if (StaticValues.RoverList != null)
                    {

                        foreach (var rover in StaticValues.RoverList)
                        {
                            RoverResultModel roverResult = roverOperations.PositionRover(StaticValues.PlateauGridSize, rover);
                            StaticValues.RoverResultList.Add(roverResult);
                        }

                        RoverResultsForm frmRoverResult = new RoverResultsForm();
                        frmRoverResult.ShowDialog();
                    }
                }
            }

            if (isWarning)
            {
                MessageBox.Show("No vehicle to send! Please add rover",
                        "No rover to send",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
        }
    }
}
