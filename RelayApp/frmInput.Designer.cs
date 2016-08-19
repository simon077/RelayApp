namespace RelayApp
{
    partial class frmInput
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
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblNumberOfDrivers = new System.Windows.Forms.Label();
            this.nudNumberOfDrivers = new System.Windows.Forms.NumericUpDown();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfDrivers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(24, 66);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(92, 23);
            this.lblStartDate.TabIndex = 6;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(69, 9);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(262, 23);
            this.lblInput.TabIndex = 4;
            this.lblInput.Text = "Please enter the following details";
            // 
            // lblNumberOfDrivers
            // 
            this.lblNumberOfDrivers.AutoSize = true;
            this.lblNumberOfDrivers.Location = new System.Drawing.Point(24, 106);
            this.lblNumberOfDrivers.Name = "lblNumberOfDrivers";
            this.lblNumberOfDrivers.Size = new System.Drawing.Size(161, 23);
            this.lblNumberOfDrivers.TabIndex = 16;
            this.lblNumberOfDrivers.Text = "Number Of Drivers:";
            // 
            // nudNumberOfDrivers
            // 
            this.nudNumberOfDrivers.BackColor = System.Drawing.SystemColors.Window;
            this.nudNumberOfDrivers.Location = new System.Drawing.Point(277, 104);
            this.nudNumberOfDrivers.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudNumberOfDrivers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfDrivers.Name = "nudNumberOfDrivers";
            this.nudNumberOfDrivers.ReadOnly = true;
            this.nudNumberOfDrivers.Size = new System.Drawing.Size(95, 30);
            this.nudNumberOfDrivers.TabIndex = 17;
            this.nudNumberOfDrivers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(154, 155);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(96, 32);
            this.btnConfirm.TabIndex = 18;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(194, 62);
            this.dtpStartDate.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.dtpStartDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(178, 30);
            this.dtpStartDate.TabIndex = 19;
            this.dtpStartDate.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // frmInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 203);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.nudNumberOfDrivers);
            this.Controls.Add(this.lblNumberOfDrivers);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblInput);
            this.Font = new System.Drawing.Font("Calibri", 14F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmInput";
            this.Text = "Car Insurance Details";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfDrivers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblNumberOfDrivers;
        private System.Windows.Forms.NumericUpDown nudNumberOfDrivers;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
    }
}

