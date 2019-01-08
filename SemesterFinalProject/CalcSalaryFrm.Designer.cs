namespace SemesterFinalProject
{
    partial class CalcSalaryFrm
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
            this.lblEnterId = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnterId
            // 
            this.lblEnterId.AutoSize = true;
            this.lblEnterId.Location = new System.Drawing.Point(28, 33);
            this.lblEnterId.Name = "lblEnterId";
            this.lblEnterId.Size = new System.Drawing.Size(45, 13);
            this.lblEnterId.TabIndex = 0;
            this.lblEnterId.Text = "enter id:";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(28, 58);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(36, 13);
            this.lblHours.TabIndex = 0;
            this.lblHours.Text = "hours:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(81, 28);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(75, 20);
            this.txtId.TabIndex = 1;
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(81, 52);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(74, 20);
            this.txtHours.TabIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.CadetBlue;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Location = new System.Drawing.Point(31, 100);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(125, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // CalcSalaryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 148);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblEnterId);
            this.Name = "CalcSalaryFrm";
            this.Text = "CalcSalaryFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterId;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Button btnOk;
    }
}