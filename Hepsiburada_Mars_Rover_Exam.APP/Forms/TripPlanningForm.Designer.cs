namespace Hepsiburada_Mars_Rover_Exam.APP.Forms
{
    partial class TripPlanningForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TripPlanningForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderText = new System.Windows.Forms.Label();
            this.pboxMinimizeButton = new System.Windows.Forms.PictureBox();
            this.pboxCloseButton = new System.Windows.Forms.PictureBox();
            this.pboxHeaderSeparator = new System.Windows.Forms.PictureBox();
            this.lblPlateauGridSize = new System.Windows.Forms.Label();
            this.nudHeightGridSize = new System.Windows.Forms.NumericUpDown();
            this.lblSeparatorX = new System.Windows.Forms.Label();
            this.nudWidthGridSize = new System.Windows.Forms.NumericUpDown();
            this.btnAddRover = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSeparatorGridSize = new System.Windows.Forms.Panel();
            this.dgvRoverList = new System.Windows.Forms.DataGridView();
            this.roverNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roverStartingDirection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roverStartingCoordinate_x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roverStartingCoordinate_y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roverRedirectCommands = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roverRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSavePlateauGridSize = new System.Windows.Forms.Button();
            this.pnlSeparatorRoverList = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMinimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxHeaderSeparator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeightGridSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidthGridSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoverList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.DimGray;
            this.pnlHeader.Controls.Add(this.lblHeaderText);
            this.pnlHeader.Controls.Add(this.pboxMinimizeButton);
            this.pnlHeader.Controls.Add(this.pboxCloseButton);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1100, 43);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeaderText
            // 
            this.lblHeaderText.AutoSize = true;
            this.lblHeaderText.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeaderText.Location = new System.Drawing.Point(12, 10);
            this.lblHeaderText.Name = "lblHeaderText";
            this.lblHeaderText.Size = new System.Drawing.Size(427, 22);
            this.lblHeaderText.TabIndex = 2;
            this.lblHeaderText.Text = "Hepsiburada Mars Rover Exam | Trip Planning";
            // 
            // pboxMinimizeButton
            // 
            this.pboxMinimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("pboxMinimizeButton.Image")));
            this.pboxMinimizeButton.Location = new System.Drawing.Point(1013, 7);
            this.pboxMinimizeButton.Name = "pboxMinimizeButton";
            this.pboxMinimizeButton.Size = new System.Drawing.Size(30, 30);
            this.pboxMinimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pboxMinimizeButton.TabIndex = 1;
            this.pboxMinimizeButton.TabStop = false;
            this.pboxMinimizeButton.Click += new System.EventHandler(this.pboxMinimizeButton_Click);
            // 
            // pboxCloseButton
            // 
            this.pboxCloseButton.Image = ((System.Drawing.Image)(resources.GetObject("pboxCloseButton.Image")));
            this.pboxCloseButton.Location = new System.Drawing.Point(1049, 7);
            this.pboxCloseButton.Name = "pboxCloseButton";
            this.pboxCloseButton.Size = new System.Drawing.Size(30, 30);
            this.pboxCloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pboxCloseButton.TabIndex = 0;
            this.pboxCloseButton.TabStop = false;
            this.pboxCloseButton.Click += new System.EventHandler(this.pboxCloseButton_Click);
            // 
            // pboxHeaderSeparator
            // 
            this.pboxHeaderSeparator.Image = ((System.Drawing.Image)(resources.GetObject("pboxHeaderSeparator.Image")));
            this.pboxHeaderSeparator.Location = new System.Drawing.Point(0, 43);
            this.pboxHeaderSeparator.Name = "pboxHeaderSeparator";
            this.pboxHeaderSeparator.Size = new System.Drawing.Size(1100, 5);
            this.pboxHeaderSeparator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxHeaderSeparator.TabIndex = 1;
            this.pboxHeaderSeparator.TabStop = false;
            // 
            // lblPlateauGridSize
            // 
            this.lblPlateauGridSize.AutoSize = true;
            this.lblPlateauGridSize.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPlateauGridSize.Location = new System.Drawing.Point(14, 75);
            this.lblPlateauGridSize.Name = "lblPlateauGridSize";
            this.lblPlateauGridSize.Size = new System.Drawing.Size(248, 24);
            this.lblPlateauGridSize.TabIndex = 2;
            this.lblPlateauGridSize.Text = "Plateau Grid Size(W,H) : ";
            // 
            // nudHeightGridSize
            // 
            this.nudHeightGridSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudHeightGridSize.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudHeightGridSize.Location = new System.Drawing.Point(402, 72);
            this.nudHeightGridSize.Name = "nudHeightGridSize";
            this.nudHeightGridSize.Size = new System.Drawing.Size(81, 33);
            this.nudHeightGridSize.TabIndex = 3;
            // 
            // lblSeparatorX
            // 
            this.lblSeparatorX.AutoSize = true;
            this.lblSeparatorX.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSeparatorX.Location = new System.Drawing.Point(363, 77);
            this.lblSeparatorX.Name = "lblSeparatorX";
            this.lblSeparatorX.Size = new System.Drawing.Size(23, 24);
            this.lblSeparatorX.TabIndex = 4;
            this.lblSeparatorX.Text = "X";
            // 
            // nudWidthGridSize
            // 
            this.nudWidthGridSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudWidthGridSize.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudWidthGridSize.Location = new System.Drawing.Point(265, 72);
            this.nudWidthGridSize.Name = "nudWidthGridSize";
            this.nudWidthGridSize.Size = new System.Drawing.Size(81, 33);
            this.nudWidthGridSize.TabIndex = 5;
            // 
            // btnAddRover
            // 
            this.btnAddRover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(95)))), ((int)(((byte)(31)))));
            this.btnAddRover.FlatAppearance.BorderSize = 0;
            this.btnAddRover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnAddRover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRover.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddRover.ForeColor = System.Drawing.Color.White;
            this.btnAddRover.Location = new System.Drawing.Point(941, 75);
            this.btnAddRover.Name = "btnAddRover";
            this.btnAddRover.Size = new System.Drawing.Size(138, 35);
            this.btnAddRover.TabIndex = 6;
            this.btnAddRover.Text = "Add Rover";
            this.btnAddRover.UseVisualStyleBackColor = false;
            this.btnAddRover.Click += new System.EventHandler(this.btnAddRover_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Rover List";
            // 
            // pnlSeparatorGridSize
            // 
            this.pnlSeparatorGridSize.BackColor = System.Drawing.Color.DimGray;
            this.pnlSeparatorGridSize.Location = new System.Drawing.Point(18, 126);
            this.pnlSeparatorGridSize.Name = "pnlSeparatorGridSize";
            this.pnlSeparatorGridSize.Size = new System.Drawing.Size(1063, 3);
            this.pnlSeparatorGridSize.TabIndex = 8;
            // 
            // dgvRoverList
            // 
            this.dgvRoverList.AllowUserToAddRows = false;
            this.dgvRoverList.AllowUserToDeleteRows = false;
            this.dgvRoverList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRoverList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(95)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoverList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRoverList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoverList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roverNo,
            this.roverName,
            this.roverStartingDirection,
            this.roverStartingCoordinate_x,
            this.roverStartingCoordinate_y,
            this.roverRedirectCommands,
            this.roverRemove});
            this.dgvRoverList.Location = new System.Drawing.Point(18, 192);
            this.dgvRoverList.Name = "dgvRoverList";
            this.dgvRoverList.ReadOnly = true;
            this.dgvRoverList.RowHeadersVisible = false;
            this.dgvRoverList.Size = new System.Drawing.Size(1064, 191);
            this.dgvRoverList.TabIndex = 9;
            this.dgvRoverList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoverList_CellContentClick);
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
            this.roverName.MinimumWidth = 50;
            this.roverName.Name = "roverName";
            this.roverName.ReadOnly = true;
            this.roverName.Width = 150;
            // 
            // roverStartingDirection
            // 
            this.roverStartingDirection.FillWeight = 180F;
            this.roverStartingDirection.HeaderText = "Starting Direction";
            this.roverStartingDirection.MinimumWidth = 100;
            this.roverStartingDirection.Name = "roverStartingDirection";
            this.roverStartingDirection.ReadOnly = true;
            this.roverStartingDirection.Width = 180;
            // 
            // roverStartingCoordinate_x
            // 
            this.roverStartingCoordinate_x.FillWeight = 200F;
            this.roverStartingCoordinate_x.HeaderText = "Starting Coordinate X";
            this.roverStartingCoordinate_x.MinimumWidth = 200;
            this.roverStartingCoordinate_x.Name = "roverStartingCoordinate_x";
            this.roverStartingCoordinate_x.ReadOnly = true;
            this.roverStartingCoordinate_x.Width = 200;
            // 
            // roverStartingCoordinate_y
            // 
            this.roverStartingCoordinate_y.FillWeight = 200F;
            this.roverStartingCoordinate_y.HeaderText = "Starting Coordinate Y";
            this.roverStartingCoordinate_y.MinimumWidth = 200;
            this.roverStartingCoordinate_y.Name = "roverStartingCoordinate_y";
            this.roverStartingCoordinate_y.ReadOnly = true;
            this.roverStartingCoordinate_y.Width = 200;
            // 
            // roverRedirectCommands
            // 
            this.roverRedirectCommands.FillWeight = 200F;
            this.roverRedirectCommands.HeaderText = "Redirect Commands";
            this.roverRedirectCommands.MinimumWidth = 150;
            this.roverRedirectCommands.Name = "roverRedirectCommands";
            this.roverRedirectCommands.ReadOnly = true;
            this.roverRedirectCommands.Width = 200;
            // 
            // roverRemove
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.roverRemove.DefaultCellStyle = dataGridViewCellStyle2;
            this.roverRemove.FillWeight = 80F;
            this.roverRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roverRemove.HeaderText = "Remove";
            this.roverRemove.Name = "roverRemove";
            this.roverRemove.ReadOnly = true;
            this.roverRemove.Text = "Remove";
            this.roverRemove.ToolTipText = "Remove";
            this.roverRemove.UseColumnTextForButtonValue = true;
            this.roverRemove.Width = 80;
            // 
            // btnSavePlateauGridSize
            // 
            this.btnSavePlateauGridSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(183)))), ((int)(((byte)(148)))));
            this.btnSavePlateauGridSize.FlatAppearance.BorderSize = 0;
            this.btnSavePlateauGridSize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnSavePlateauGridSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePlateauGridSize.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSavePlateauGridSize.ForeColor = System.Drawing.Color.White;
            this.btnSavePlateauGridSize.Location = new System.Drawing.Point(505, 71);
            this.btnSavePlateauGridSize.Name = "btnSavePlateauGridSize";
            this.btnSavePlateauGridSize.Size = new System.Drawing.Size(99, 35);
            this.btnSavePlateauGridSize.TabIndex = 10;
            this.btnSavePlateauGridSize.Text = "Save";
            this.btnSavePlateauGridSize.UseVisualStyleBackColor = false;
            this.btnSavePlateauGridSize.Click += new System.EventHandler(this.btnSavePlateauGridSize_Click);
            // 
            // pnlSeparatorRoverList
            // 
            this.pnlSeparatorRoverList.BackColor = System.Drawing.Color.DimGray;
            this.pnlSeparatorRoverList.Location = new System.Drawing.Point(16, 183);
            this.pnlSeparatorRoverList.Name = "pnlSeparatorRoverList";
            this.pnlSeparatorRoverList.Size = new System.Drawing.Size(1063, 3);
            this.pnlSeparatorRoverList.TabIndex = 9;
            // 
            // TripPlanningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1100, 403);
            this.Controls.Add(this.pnlSeparatorRoverList);
            this.Controls.Add(this.btnSavePlateauGridSize);
            this.Controls.Add(this.dgvRoverList);
            this.Controls.Add(this.pnlSeparatorGridSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddRover);
            this.Controls.Add(this.nudWidthGridSize);
            this.Controls.Add(this.lblSeparatorX);
            this.Controls.Add(this.nudHeightGridSize);
            this.Controls.Add(this.lblPlateauGridSize);
            this.Controls.Add(this.pboxHeaderSeparator);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TripPlanningForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trip Planning";
            this.Load += new System.EventHandler(this.TripPlanningForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMinimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxHeaderSeparator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeightGridSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidthGridSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoverList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox pboxMinimizeButton;
        private System.Windows.Forms.PictureBox pboxCloseButton;
        private System.Windows.Forms.PictureBox pboxHeaderSeparator;
        private System.Windows.Forms.Label lblHeaderText;
        private System.Windows.Forms.Label lblPlateauGridSize;
        private System.Windows.Forms.NumericUpDown nudHeightGridSize;
        private System.Windows.Forms.Label lblSeparatorX;
        private System.Windows.Forms.NumericUpDown nudWidthGridSize;
        private System.Windows.Forms.Button btnAddRover;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlSeparatorGridSize;
        private System.Windows.Forms.DataGridView dgvRoverList;
        private System.Windows.Forms.Button btnSavePlateauGridSize;
        private System.Windows.Forms.Panel pnlSeparatorRoverList;
        private System.Windows.Forms.DataGridViewTextBoxColumn roverNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn roverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn roverStartingDirection;
        private System.Windows.Forms.DataGridViewTextBoxColumn roverStartingCoordinate_x;
        private System.Windows.Forms.DataGridViewTextBoxColumn roverStartingCoordinate_y;
        private System.Windows.Forms.DataGridViewTextBoxColumn roverRedirectCommands;
        private System.Windows.Forms.DataGridViewButtonColumn roverRemove;
    }
}