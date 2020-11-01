namespace Hepsiburada_Mars_Rover_Exam.APP.Forms
{
    partial class AddRoverForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRoverForm));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderText = new System.Windows.Forms.Label();
            this.pboxCloseButton = new System.Windows.Forms.PictureBox();
            this.pboxHeaderSeparator = new System.Windows.Forms.PictureBox();
            this.lblRoverNumber = new System.Windows.Forms.Label();
            this.lblRoverName = new System.Windows.Forms.Label();
            this.lblStartingCoordinate = new System.Windows.Forms.Label();
            this.lblStartingDirection = new System.Windows.Forms.Label();
            this.rbtnNorth = new System.Windows.Forms.RadioButton();
            this.txtRoverNumber = new System.Windows.Forms.TextBox();
            this.txtRoverName = new System.Windows.Forms.TextBox();
            this.nudStartingCoordinate_X = new System.Windows.Forms.NumericUpDown();
            this.nudStartingCoordinate_Y = new System.Windows.Forms.NumericUpDown();
            this.lblSeparatorTire = new System.Windows.Forms.Label();
            this.rbtnWest = new System.Windows.Forms.RadioButton();
            this.rbtnSouth = new System.Windows.Forms.RadioButton();
            this.rbtnEast = new System.Windows.Forms.RadioButton();
            this.btnRedirectLeft = new System.Windows.Forms.Button();
            this.btnRedirectMove = new System.Windows.Forms.Button();
            this.btnRedirectRight = new System.Windows.Forms.Button();
            this.btnRedirectBackspace = new System.Windows.Forms.Button();
            this.txtRedirectCommands = new System.Windows.Forms.TextBox();
            this.btnAddRover = new System.Windows.Forms.Button();
            this.gboxRedirectCommands = new System.Windows.Forms.GroupBox();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxHeaderSeparator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartingCoordinate_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartingCoordinate_Y)).BeginInit();
            this.gboxRedirectCommands.SuspendLayout();
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
            this.pnlHeader.Size = new System.Drawing.Size(558, 43);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblHeaderText
            // 
            this.lblHeaderText.AutoSize = true;
            this.lblHeaderText.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeaderText.Location = new System.Drawing.Point(12, 10);
            this.lblHeaderText.Name = "lblHeaderText";
            this.lblHeaderText.Size = new System.Drawing.Size(414, 22);
            this.lblHeaderText.TabIndex = 2;
            this.lblHeaderText.Text = "Hepsiburada Mars Rover Exam | Add Rover";
            // 
            // pboxCloseButton
            // 
            this.pboxCloseButton.Image = ((System.Drawing.Image)(resources.GetObject("pboxCloseButton.Image")));
            this.pboxCloseButton.Location = new System.Drawing.Point(506, 6);
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
            this.pboxHeaderSeparator.Location = new System.Drawing.Point(0, 42);
            this.pboxHeaderSeparator.Name = "pboxHeaderSeparator";
            this.pboxHeaderSeparator.Size = new System.Drawing.Size(558, 5);
            this.pboxHeaderSeparator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxHeaderSeparator.TabIndex = 2;
            this.pboxHeaderSeparator.TabStop = false;
            // 
            // lblRoverNumber
            // 
            this.lblRoverNumber.AutoSize = true;
            this.lblRoverNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRoverNumber.Location = new System.Drawing.Point(29, 76);
            this.lblRoverNumber.Name = "lblRoverNumber";
            this.lblRoverNumber.Size = new System.Drawing.Size(130, 21);
            this.lblRoverNumber.TabIndex = 3;
            this.lblRoverNumber.Text = "Rover Number :";
            // 
            // lblRoverName
            // 
            this.lblRoverName.AutoSize = true;
            this.lblRoverName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRoverName.Location = new System.Drawing.Point(29, 143);
            this.lblRoverName.Name = "lblRoverName";
            this.lblRoverName.Size = new System.Drawing.Size(115, 21);
            this.lblRoverName.TabIndex = 4;
            this.lblRoverName.Text = "Rover Name :";
            // 
            // lblStartingCoordinate
            // 
            this.lblStartingCoordinate.AutoSize = true;
            this.lblStartingCoordinate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStartingCoordinate.Location = new System.Drawing.Point(29, 214);
            this.lblStartingCoordinate.Name = "lblStartingCoordinate";
            this.lblStartingCoordinate.Size = new System.Drawing.Size(210, 21);
            this.lblStartingCoordinate.TabIndex = 6;
            this.lblStartingCoordinate.Text = "Starting Coordinate(X,Y) :";
            // 
            // lblStartingDirection
            // 
            this.lblStartingDirection.AutoSize = true;
            this.lblStartingDirection.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStartingDirection.Location = new System.Drawing.Point(32, 288);
            this.lblStartingDirection.Name = "lblStartingDirection";
            this.lblStartingDirection.Size = new System.Drawing.Size(154, 21);
            this.lblStartingDirection.TabIndex = 7;
            this.lblStartingDirection.Text = "Starting Direction :";
            // 
            // rbtnNorth
            // 
            this.rbtnNorth.AutoSize = true;
            this.rbtnNorth.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnNorth.Location = new System.Drawing.Point(36, 316);
            this.rbtnNorth.Name = "rbtnNorth";
            this.rbtnNorth.Size = new System.Drawing.Size(85, 20);
            this.rbtnNorth.TabIndex = 5;
            this.rbtnNorth.TabStop = true;
            this.rbtnNorth.Text = "North (N)";
            this.rbtnNorth.UseVisualStyleBackColor = true;
            // 
            // txtRoverNumber
            // 
            this.txtRoverNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRoverNumber.Location = new System.Drawing.Point(33, 100);
            this.txtRoverNumber.Name = "txtRoverNumber";
            this.txtRoverNumber.ReadOnly = true;
            this.txtRoverNumber.Size = new System.Drawing.Size(217, 27);
            this.txtRoverNumber.TabIndex = 1;
            // 
            // txtRoverName
            // 
            this.txtRoverName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRoverName.Location = new System.Drawing.Point(33, 167);
            this.txtRoverName.Name = "txtRoverName";
            this.txtRoverName.Size = new System.Drawing.Size(217, 27);
            this.txtRoverName.TabIndex = 2;
            // 
            // nudStartingCoordinate_X
            // 
            this.nudStartingCoordinate_X.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudStartingCoordinate_X.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudStartingCoordinate_X.Location = new System.Drawing.Point(34, 240);
            this.nudStartingCoordinate_X.Name = "nudStartingCoordinate_X";
            this.nudStartingCoordinate_X.Size = new System.Drawing.Size(72, 27);
            this.nudStartingCoordinate_X.TabIndex = 3;
            // 
            // nudStartingCoordinate_Y
            // 
            this.nudStartingCoordinate_Y.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudStartingCoordinate_Y.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudStartingCoordinate_Y.Location = new System.Drawing.Point(146, 241);
            this.nudStartingCoordinate_Y.Name = "nudStartingCoordinate_Y";
            this.nudStartingCoordinate_Y.Size = new System.Drawing.Size(72, 27);
            this.nudStartingCoordinate_Y.TabIndex = 4;
            // 
            // lblSeparatorTire
            // 
            this.lblSeparatorTire.AutoSize = true;
            this.lblSeparatorTire.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSeparatorTire.Location = new System.Drawing.Point(117, 242);
            this.lblSeparatorTire.Name = "lblSeparatorTire";
            this.lblSeparatorTire.Size = new System.Drawing.Size(17, 24);
            this.lblSeparatorTire.TabIndex = 13;
            this.lblSeparatorTire.Text = "-";
            // 
            // rbtnWest
            // 
            this.rbtnWest.AutoSize = true;
            this.rbtnWest.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnWest.Location = new System.Drawing.Point(294, 316);
            this.rbtnWest.Name = "rbtnWest";
            this.rbtnWest.Size = new System.Drawing.Size(82, 20);
            this.rbtnWest.TabIndex = 8;
            this.rbtnWest.TabStop = true;
            this.rbtnWest.Text = "West (W)";
            this.rbtnWest.UseVisualStyleBackColor = true;
            // 
            // rbtnSouth
            // 
            this.rbtnSouth.AutoSize = true;
            this.rbtnSouth.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnSouth.Location = new System.Drawing.Point(206, 316);
            this.rbtnSouth.Name = "rbtnSouth";
            this.rbtnSouth.Size = new System.Drawing.Size(82, 20);
            this.rbtnSouth.TabIndex = 7;
            this.rbtnSouth.TabStop = true;
            this.rbtnSouth.Text = "South (S)";
            this.rbtnSouth.UseVisualStyleBackColor = true;
            // 
            // rbtnEast
            // 
            this.rbtnEast.AutoSize = true;
            this.rbtnEast.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnEast.Location = new System.Drawing.Point(127, 316);
            this.rbtnEast.Name = "rbtnEast";
            this.rbtnEast.Size = new System.Drawing.Size(73, 20);
            this.rbtnEast.TabIndex = 6;
            this.rbtnEast.TabStop = true;
            this.rbtnEast.Text = "East (E)";
            this.rbtnEast.UseVisualStyleBackColor = true;
            // 
            // btnRedirectLeft
            // 
            this.btnRedirectLeft.BackColor = System.Drawing.Color.DimGray;
            this.btnRedirectLeft.FlatAppearance.BorderSize = 0;
            this.btnRedirectLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnRedirectLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedirectLeft.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRedirectLeft.ForeColor = System.Drawing.Color.White;
            this.btnRedirectLeft.Location = new System.Drawing.Point(16, 46);
            this.btnRedirectLeft.Name = "btnRedirectLeft";
            this.btnRedirectLeft.Size = new System.Drawing.Size(84, 38);
            this.btnRedirectLeft.TabIndex = 9;
            this.btnRedirectLeft.Text = "Left";
            this.btnRedirectLeft.UseVisualStyleBackColor = false;
            this.btnRedirectLeft.Click += new System.EventHandler(this.btnRedirectLeft_Click);
            // 
            // btnRedirectMove
            // 
            this.btnRedirectMove.BackColor = System.Drawing.Color.DimGray;
            this.btnRedirectMove.FlatAppearance.BorderSize = 0;
            this.btnRedirectMove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnRedirectMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedirectMove.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRedirectMove.ForeColor = System.Drawing.Color.White;
            this.btnRedirectMove.Location = new System.Drawing.Point(115, 46);
            this.btnRedirectMove.Name = "btnRedirectMove";
            this.btnRedirectMove.Size = new System.Drawing.Size(84, 38);
            this.btnRedirectMove.TabIndex = 10;
            this.btnRedirectMove.Text = "Move";
            this.btnRedirectMove.UseVisualStyleBackColor = false;
            this.btnRedirectMove.Click += new System.EventHandler(this.btnRedirectMove_Click);
            // 
            // btnRedirectRight
            // 
            this.btnRedirectRight.BackColor = System.Drawing.Color.DimGray;
            this.btnRedirectRight.FlatAppearance.BorderSize = 0;
            this.btnRedirectRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnRedirectRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedirectRight.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRedirectRight.ForeColor = System.Drawing.Color.White;
            this.btnRedirectRight.Location = new System.Drawing.Point(216, 46);
            this.btnRedirectRight.Name = "btnRedirectRight";
            this.btnRedirectRight.Size = new System.Drawing.Size(84, 38);
            this.btnRedirectRight.TabIndex = 11;
            this.btnRedirectRight.Text = "Right";
            this.btnRedirectRight.UseVisualStyleBackColor = false;
            this.btnRedirectRight.Click += new System.EventHandler(this.btnRedirectRight_Click);
            // 
            // btnRedirectBackspace
            // 
            this.btnRedirectBackspace.BackColor = System.Drawing.Color.Crimson;
            this.btnRedirectBackspace.FlatAppearance.BorderSize = 0;
            this.btnRedirectBackspace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnRedirectBackspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedirectBackspace.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRedirectBackspace.ForeColor = System.Drawing.Color.White;
            this.btnRedirectBackspace.Location = new System.Drawing.Point(317, 46);
            this.btnRedirectBackspace.Name = "btnRedirectBackspace";
            this.btnRedirectBackspace.Size = new System.Drawing.Size(142, 38);
            this.btnRedirectBackspace.TabIndex = 12;
            this.btnRedirectBackspace.Text = "Backspace";
            this.btnRedirectBackspace.UseVisualStyleBackColor = false;
            this.btnRedirectBackspace.Click += new System.EventHandler(this.btnRedirectBackspace_Click);
            // 
            // txtRedirectCommands
            // 
            this.txtRedirectCommands.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRedirectCommands.Location = new System.Drawing.Point(16, 102);
            this.txtRedirectCommands.Name = "txtRedirectCommands";
            this.txtRedirectCommands.ReadOnly = true;
            this.txtRedirectCommands.Size = new System.Drawing.Size(443, 31);
            this.txtRedirectCommands.TabIndex = 13;
            // 
            // btnAddRover
            // 
            this.btnAddRover.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddRover.FlatAppearance.BorderSize = 0;
            this.btnAddRover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnAddRover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRover.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddRover.ForeColor = System.Drawing.Color.White;
            this.btnAddRover.Location = new System.Drawing.Point(36, 531);
            this.btnAddRover.Name = "btnAddRover";
            this.btnAddRover.Size = new System.Drawing.Size(484, 38);
            this.btnAddRover.TabIndex = 14;
            this.btnAddRover.Text = "Add Rover";
            this.btnAddRover.UseVisualStyleBackColor = false;
            this.btnAddRover.Click += new System.EventHandler(this.btnAddRover_Click);
            // 
            // gboxRedirectCommands
            // 
            this.gboxRedirectCommands.Controls.Add(this.btnRedirectBackspace);
            this.gboxRedirectCommands.Controls.Add(this.btnRedirectLeft);
            this.gboxRedirectCommands.Controls.Add(this.txtRedirectCommands);
            this.gboxRedirectCommands.Controls.Add(this.btnRedirectMove);
            this.gboxRedirectCommands.Controls.Add(this.btnRedirectRight);
            this.gboxRedirectCommands.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gboxRedirectCommands.Location = new System.Drawing.Point(34, 351);
            this.gboxRedirectCommands.Name = "gboxRedirectCommands";
            this.gboxRedirectCommands.Size = new System.Drawing.Size(486, 148);
            this.gboxRedirectCommands.TabIndex = 23;
            this.gboxRedirectCommands.TabStop = false;
            this.gboxRedirectCommands.Text = "Redirect Commands ";
            // 
            // AddRoverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 609);
            this.Controls.Add(this.gboxRedirectCommands);
            this.Controls.Add(this.btnAddRover);
            this.Controls.Add(this.rbtnEast);
            this.Controls.Add(this.rbtnSouth);
            this.Controls.Add(this.rbtnWest);
            this.Controls.Add(this.lblSeparatorTire);
            this.Controls.Add(this.nudStartingCoordinate_Y);
            this.Controls.Add(this.nudStartingCoordinate_X);
            this.Controls.Add(this.txtRoverName);
            this.Controls.Add(this.txtRoverNumber);
            this.Controls.Add(this.rbtnNorth);
            this.Controls.Add(this.lblStartingDirection);
            this.Controls.Add(this.lblStartingCoordinate);
            this.Controls.Add(this.lblRoverName);
            this.Controls.Add(this.lblRoverNumber);
            this.Controls.Add(this.pboxHeaderSeparator);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddRoverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddRoverForm";
            this.Load += new System.EventHandler(this.AddRoverForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxHeaderSeparator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartingCoordinate_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartingCoordinate_Y)).EndInit();
            this.gboxRedirectCommands.ResumeLayout(false);
            this.gboxRedirectCommands.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderText;
        private System.Windows.Forms.PictureBox pboxCloseButton;
        private System.Windows.Forms.PictureBox pboxHeaderSeparator;
        private System.Windows.Forms.Label lblRoverNumber;
        private System.Windows.Forms.Label lblRoverName;
        private System.Windows.Forms.Label lblStartingCoordinate;
        private System.Windows.Forms.Label lblStartingDirection;
        private System.Windows.Forms.RadioButton rbtnNorth;
        private System.Windows.Forms.TextBox txtRoverNumber;
        private System.Windows.Forms.TextBox txtRoverName;
        private System.Windows.Forms.NumericUpDown nudStartingCoordinate_X;
        private System.Windows.Forms.NumericUpDown nudStartingCoordinate_Y;
        private System.Windows.Forms.Label lblSeparatorTire;
        private System.Windows.Forms.RadioButton rbtnWest;
        private System.Windows.Forms.RadioButton rbtnSouth;
        private System.Windows.Forms.RadioButton rbtnEast;
        private System.Windows.Forms.Button btnRedirectLeft;
        private System.Windows.Forms.Button btnRedirectMove;
        private System.Windows.Forms.Button btnRedirectRight;
        private System.Windows.Forms.Button btnRedirectBackspace;
        private System.Windows.Forms.TextBox txtRedirectCommands;
        private System.Windows.Forms.Button btnAddRover;
        private System.Windows.Forms.GroupBox gboxRedirectCommands;
    }
}