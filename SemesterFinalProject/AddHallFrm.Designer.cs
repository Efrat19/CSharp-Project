namespace SemesterFinalProject
{
    partial class AddHallFrm
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
            this.nudSeats = new System.Windows.Forms.NumericUpDown();
            this.lblSeats = new System.Windows.Forms.Label();
            this.lblCodeValue = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeats)).BeginInit();
            this.SuspendLayout();
            // 
            // nudSeats
            // 
            this.nudSeats.Location = new System.Drawing.Point(96, 52);
            this.nudSeats.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSeats.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSeats.Name = "nudSeats";
            this.nudSeats.Size = new System.Drawing.Size(100, 20);
            this.nudSeats.TabIndex = 29;
            this.nudSeats.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSeats
            // 
            this.lblSeats.AutoSize = true;
            this.lblSeats.Location = new System.Drawing.Point(24, 54);
            this.lblSeats.Name = "lblSeats";
            this.lblSeats.Size = new System.Drawing.Size(70, 13);
            this.lblSeats.TabIndex = 26;
            this.lblSeats.Text = "seats number";
            // 
            // lblCodeValue
            // 
            this.lblCodeValue.AutoSize = true;
            this.lblCodeValue.Location = new System.Drawing.Point(78, 13);
            this.lblCodeValue.Name = "lblCodeValue";
            this.lblCodeValue.Size = new System.Drawing.Size(31, 13);
            this.lblCodeValue.TabIndex = 31;
            this.lblCodeValue.Text = "code";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(25, 13);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(56, 13);
            this.lblCode.TabIndex = 30;
            this.lblCode.Text = "play code:";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.CadetBlue;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Location = new System.Drawing.Point(28, 92);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(168, 23);
            this.btnOk.TabIndex = 32;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // AddHallFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 132);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblCodeValue);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.nudSeats);
            this.Controls.Add(this.lblSeats);
            this.Name = "AddHallFrm";
            this.Text = "add new hall";
            this.Load += new System.EventHandler(this.AddHallFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSeats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudSeats;
        private System.Windows.Forms.Label lblSeats;
        private System.Windows.Forms.Label lblCodeValue;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Button btnOk;
    }
}