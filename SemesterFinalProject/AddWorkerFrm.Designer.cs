namespace SemesterFinalProject
{
    partial class AddWorkerFrm
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
            this.btnOK = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.grbClientType = new System.Windows.Forms.GroupBox();
            this.rbtWorker = new System.Windows.Forms.RadioButton();
            this.rbtBoss = new System.Windows.Forms.RadioButton();
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.cmbBoss = new System.Windows.Forms.ComboBox();
            this.lblBoss = new System.Windows.Forms.Label();
            this.lblSph = new System.Windows.Forms.Label();
            this.txtSph = new System.Windows.Forms.TextBox();
            this.grbClientType.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.CadetBlue;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Location = new System.Drawing.Point(62, 294);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(137, 23);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(99, 199);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 11;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(99, 173);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 12;
            // 
            // grbClientType
            // 
            this.grbClientType.Controls.Add(this.rbtWorker);
            this.grbClientType.Controls.Add(this.rbtBoss);
            this.grbClientType.Location = new System.Drawing.Point(62, 83);
            this.grbClientType.Name = "grbClientType";
            this.grbClientType.Size = new System.Drawing.Size(137, 71);
            this.grbClientType.TabIndex = 10;
            this.grbClientType.TabStop = false;
            this.grbClientType.Text = "worker type:";
            // 
            // rbtWorker
            // 
            this.rbtWorker.AutoSize = true;
            this.rbtWorker.Location = new System.Drawing.Point(10, 44);
            this.rbtWorker.Name = "rbtWorker";
            this.rbtWorker.Size = new System.Drawing.Size(57, 17);
            this.rbtWorker.TabIndex = 3;
            this.rbtWorker.Text = "worker";
            this.rbtWorker.UseVisualStyleBackColor = true;
            this.rbtWorker.CheckedChanged += new System.EventHandler(this.rbtWorker_CheckedChanged);
            // 
            // rbtBoss
            // 
            this.rbtBoss.AutoSize = true;
            this.rbtBoss.Checked = true;
            this.rbtBoss.Location = new System.Drawing.Point(10, 21);
            this.rbtBoss.Name = "rbtBoss";
            this.rbtBoss.Size = new System.Drawing.Size(47, 17);
            this.rbtBoss.TabIndex = 4;
            this.rbtBoss.TabStop = true;
            this.rbtBoss.Text = "boss";
            this.rbtBoss.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(64, 202);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(33, 13);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "name";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(82, 176);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(15, 13);
            this.lblId.TabIndex = 8;
            this.lblId.Text = "id";
            // 
            // cmbBoss
            // 
            this.cmbBoss.FormattingEnabled = true;
            this.cmbBoss.Location = new System.Drawing.Point(99, 251);
            this.cmbBoss.Name = "cmbBoss";
            this.cmbBoss.Size = new System.Drawing.Size(100, 21);
            this.cmbBoss.TabIndex = 14;
            this.cmbBoss.Visible = false;
            // 
            // lblBoss
            // 
            this.lblBoss.AutoSize = true;
            this.lblBoss.Location = new System.Drawing.Point(64, 254);
            this.lblBoss.Name = "lblBoss";
            this.lblBoss.Size = new System.Drawing.Size(29, 13);
            this.lblBoss.TabIndex = 9;
            this.lblBoss.Text = "boss";
            this.lblBoss.Visible = false;
            // 
            // lblSph
            // 
            this.lblSph.AutoSize = true;
            this.lblSph.Location = new System.Drawing.Point(73, 228);
            this.lblSph.Name = "lblSph";
            this.lblSph.Size = new System.Drawing.Size(24, 13);
            this.lblSph.TabIndex = 9;
            this.lblSph.Text = "sph";
            // 
            // txtSph
            // 
            this.txtSph.Location = new System.Drawing.Point(99, 225);
            this.txtSph.Name = "txtSph";
            this.txtSph.Size = new System.Drawing.Size(100, 20);
            this.txtSph.TabIndex = 11;
            // 
            // AddWorkerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 400);
            this.Controls.Add(this.cmbBoss);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtSph);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.grbClientType);
            this.Controls.Add(this.lblSph);
            this.Controls.Add(this.lblBoss);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Name = "AddWorkerFrm";
            this.Text = "Add Worker";
            this.Load += new System.EventHandler(this.AddWorkerFrm_Load);
            this.grbClientType.ResumeLayout(false);
            this.grbClientType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.GroupBox grbClientType;
        private System.Windows.Forms.RadioButton rbtWorker;
        private System.Windows.Forms.RadioButton rbtBoss;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox cmbBoss;
        private System.Windows.Forms.Label lblBoss;
        private System.Windows.Forms.Label lblSph;
        private System.Windows.Forms.TextBox txtSph;
    }
}