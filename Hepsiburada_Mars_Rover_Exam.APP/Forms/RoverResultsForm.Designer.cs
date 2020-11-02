namespace Hepsiburada_Mars_Rover_Exam.APP.Forms
{
    partial class RoverResultsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoverResultsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderText = new System.Windows.Forms.Label();
            this.pboxCloseButton = new System.Windows.Forms.PictureBox();
            this.dgvRoverResults = new System.Windows.Forms.DataGridView();
            this.roverNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plateauSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startingCoordinate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endCoordinate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coordinateHistory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoverResults)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.DimGray;
            this.pnlHeader.Controls.Add(this.lblHeaderText);
            this.pnlHeader.Controls.Add(this.pboxCloseButton);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(984, 43);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblHeaderText
            // 
            this.lblHeaderText.AutoSize = true;
            this.lblHeaderText.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeaderText.Location = new System.Drawing.Point(12, 10);
            this.lblHeaderText.Name = "lblHeaderText";
            this.lblHeaderText.Size = new System.Drawing.Size(433, 22);
            this.lblHeaderText.TabIndex = 2;
            this.lblHeaderText.Text = "Hepsiburada Mars Rover Exam | Rover Results";
            // 
            // pboxCloseButton
            // 
            this.pboxCloseButton.Image = ((System.Drawing.Image)(resources.GetObject("pboxCloseButton.Image")));
            this.pboxCloseButton.Location = new System.Drawing.Point(938, 5);
            this.pboxCloseButton.Name = "pboxCloseButton";
            this.pboxCloseButton.Size = new System.Drawing.Size(30, 30);
            this.pboxCloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pboxCloseButton.TabIndex = 0;
            this.pboxCloseButton.TabStop = false;
            this.pboxCloseButton.Click += new System.EventHandler(this.pboxCloseButton_Click);
            // 
            // dgvRoverResults
            // 
            this.dgvRoverResults.AllowUserToAddRows = false;
            this.dgvRoverResults.AllowUserToDeleteRows = false;
            this.dgvRoverResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRoverResults.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRoverResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRoverResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoverResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roverNo,
            this.roverName,
            this.plateauSize,
            this.startingCoordinate,
            this.endCoordinate,
            this.coordinateHistory});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoverResults.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRoverResults.Location = new System.Drawing.Point(16, 58);
            this.dgvRoverResults.Name = "dgvRoverResults";
            this.dgvRoverResults.ReadOnly = true;
            this.dgvRoverResults.RowHeadersVisible = false;
            this.dgvRoverResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoverResults.Size = new System.Drawing.Size(954, 364);
            this.dgvRoverResults.TabIndex = 2;
            // 
            // roverNo
            // 
            this.roverNo.FillWeight = 50F;
            this.roverNo.HeaderText = "No";
            this.roverNo.MinimumWidth = 50;
            this.roverNo.Name = "roverNo";
            this.roverNo.ReadOnly = true;
            this.roverNo.Width = 50;
            // 
            // roverName
            // 
            this.roverName.FillWeight = 150F;
            this.roverName.HeaderText = "Name";
            this.roverName.MinimumWidth = 100;
            this.roverName.Name = "roverName";
            this.roverName.ReadOnly = true;
            this.roverName.Width = 150;
            // 
            // plateauSize
            // 
            this.plateauSize.FillWeight = 150F;
            this.plateauSize.HeaderText = "Plateau Size";
            this.plateauSize.MinimumWidth = 150;
            this.plateauSize.Name = "plateauSize";
            this.plateauSize.ReadOnly = true;
            this.plateauSize.Width = 150;
            // 
            // startingCoordinate
            // 
            this.startingCoordinate.FillWeight = 200F;
            this.startingCoordinate.HeaderText = "Starting Coordinate";
            this.startingCoordinate.MinimumWidth = 200;
            this.startingCoordinate.Name = "startingCoordinate";
            this.startingCoordinate.ReadOnly = true;
            this.startingCoordinate.Width = 200;
            // 
            // endCoordinate
            // 
            this.endCoordinate.FillWeight = 200F;
            this.endCoordinate.HeaderText = "End Coordinate";
            this.endCoordinate.MinimumWidth = 200;
            this.endCoordinate.Name = "endCoordinate";
            this.endCoordinate.ReadOnly = true;
            this.endCoordinate.Width = 200;
            // 
            // coordinateHistory
            // 
            this.coordinateHistory.FillWeight = 200F;
            this.coordinateHistory.HeaderText = "Coordinate History";
            this.coordinateHistory.MinimumWidth = 200;
            this.coordinateHistory.Name = "coordinateHistory";
            this.coordinateHistory.ReadOnly = true;
            this.coordinateHistory.Width = 200;
            // 
            // RoverResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 440);
            this.Controls.Add(this.dgvRoverResults);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RoverResultsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rover Results Form";
            this.Load += new System.EventHandler(this.RoverResultsForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoverResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderText;
        private System.Windows.Forms.PictureBox pboxCloseButton;
        private System.Windows.Forms.DataGridView dgvRoverResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn roverNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn roverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn plateauSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn startingCoordinate;
        private System.Windows.Forms.DataGridViewTextBoxColumn endCoordinate;
        private System.Windows.Forms.DataGridViewTextBoxColumn coordinateHistory;
    }
}