using Hepsiburada_Mars_Rover_Exam.APP.Helpers;
using Hepsiburada_Mars_Rover_Exam.APP.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Hepsiburada_Mars_Rover_Exam.APP.Forms
{
    public partial class AddRoverForm : Form
    {
        public AddRoverForm()
        {
            InitializeComponent();
        }

        private void AddRoverForm_Load(object sender, EventArgs e)
        {
            txtRoverNumber.Text = GetRoverNumber();
        }

        private void btnAddRover_Click(object sender, EventArgs e)
        {
            RoverValidationModel validationModel = FormValidation();

            if (validationModel.isValid)
            {
                RoverModel roverModel = new RoverModel()
                {
                    RoverNumber = Convert.ToInt32(txtRoverNumber.Text),
                    RoverName = txtRoverName.Text,
                    StartingCoordinate_X = (int)nudStartingCoordinate_X.Value,
                    StartingCoordinate_Y = (int)nudStartingCoordinate_Y.Value,
                    StartingDirection = GetSelectedDirectionValue(),
                    RedirectCommands = txtRedirectCommands.Text.Replace("-","")
                };

                StaticValues.RoverList.Add(roverModel);

                MessageBox.Show("Rover successfully added", "Rover Added",MessageBoxButtons.OK,MessageBoxIcon.Information);
                ClearRoverForm();
            }
            else
            {
                MessageBox.Show(String.Join(Environment.NewLine, validationModel.Messages.OfType<Object>()),
                    "Form Validation Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private char GetSelectedDirectionValue()
        {
            if (rbtnWest.Checked)
                return 'W';
            else if (rbtnSouth.Checked)
                return 'S';
            else if (rbtnNorth.Checked)
                return 'N';
            else if (rbtnEast.Checked)
                return 'E';
            else
                return 'X';
        }

        private string GetRoverNumber()
        {
            if (StaticValues.RoverList != null)
            {
                if (StaticValues.RoverList.Count > 0)
                {
                    int roverNumber = StaticValues.RoverList.Select(x => x.RoverNumber).Max();
                    return (roverNumber + 1).ToString();
                }
            }
            return "1";
        }

        private RoverValidationModel FormValidation()
        {
            RoverValidationModel validationModel = new RoverValidationModel();
            validationModel.isValid = true;
            validationModel.Messages = new List<string>();

            if (String.IsNullOrEmpty(txtRoverName.Text))
            {
                validationModel.isValid = false;
                validationModel.Messages.Add("Please fill in the Rover Name field");
            }

            if (String.IsNullOrEmpty(txtRedirectCommands.Text))
            {
                validationModel.isValid = false;
                validationModel.Messages.Add("Please fill in the Reidrect Commands field");
            }

            if (nudStartingCoordinate_X.Value == 0)
            {
                validationModel.isValid = false;
                validationModel.Messages.Add("Please fill in the Starting Coordination X field");
            }

            var plateauGridSize = StaticValues.PlateauGridSize;

            if (nudStartingCoordinate_X.Value > plateauGridSize.PlateauWidth)
            {
                validationModel.isValid = false;
                validationModel.Messages.Add(
                    $"Field Starting Coordinate X cannot exceed grid width (MAX:{plateauGridSize.PlateauWidth})");
            }

            if (nudStartingCoordinate_Y.Value == 0)
            {
                validationModel.isValid = false;
                validationModel.Messages.Add("Please fill in the Starting Coordination Y field");
            }

            if (nudStartingCoordinate_Y.Value > plateauGridSize.PlateauHeight)
            {
                validationModel.isValid = false;
                validationModel.Messages.Add(
                    $"Field Starting Coordinate Y cannot exceed grid height (MAX:{plateauGridSize.PlateauHeight})");
            }

            if (!rbtnEast.Checked && !rbtnNorth.Checked && !rbtnSouth.Checked && !rbtnWest.Checked)
            {
                validationModel.isValid = false;
                validationModel.Messages.Add("Please fill in the Starting Direction field");
            }

            return validationModel;
        }

        private void pboxCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRedirectLeft_Click(object sender, EventArgs e)
        {
            if (txtRedirectCommands.Text.Length > 0)
                txtRedirectCommands.Text += "-L";
            else
                txtRedirectCommands.Text += "L";
        }

        private void btnRedirectMove_Click(object sender, EventArgs e)
        {
            if (txtRedirectCommands.Text.Length > 0)
                txtRedirectCommands.Text += "-M";
            else
                txtRedirectCommands.Text += "M";
        }

        private void btnRedirectRight_Click(object sender, EventArgs e)
        {
            if (txtRedirectCommands.Text.Length > 0)
                txtRedirectCommands.Text += "-R";
            else
                txtRedirectCommands.Text += "R";
        }

        private void btnRedirectBackspace_Click(object sender, EventArgs e)
        {
            if (txtRedirectCommands.Text.Length > 1)
                txtRedirectCommands.Text = txtRedirectCommands.Text.Substring(0, txtRedirectCommands.Text.Length - 2);
            else if (txtRedirectCommands.Text.Length > 0)
                txtRedirectCommands.Text = txtRedirectCommands.Text.Substring(0, txtRedirectCommands.Text.Length - 1);
        }

        private void ClearRoverForm()
        {
            txtRoverNumber.Text = GetRoverNumber();
            txtRoverName.Clear();
            txtRedirectCommands.Clear();
            nudStartingCoordinate_X.Value = 0;
            nudStartingCoordinate_Y.Value = 0;
            rbtnEast.Checked = false;
            rbtnNorth.Checked = false;
            rbtnSouth.Checked = false;
            rbtnWest.Checked = false;
        }
    }
}
