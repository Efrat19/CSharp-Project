namespace SemesterFinalProject
{
    partial class AddClientFrm
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
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.rbtPublic = new System.Windows.Forms.RadioButton();
            this.rbtPrivate = new System.Windows.Forms.RadioButton();
            this.grbClientType = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.grbClientType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(86, 156);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(15, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "id";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(68, 186);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(33, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "name";
            // 
            // rbtPublic
            // 
            this.rbtPublic.AutoSize = true;
            this.rbtPublic.Location = new System.Drawing.Point(10, 44);
            this.rbtPublic.Name = "rbtPublic";
            this.rbtPublic.Size = new System.Drawing.Size(53, 17);
            this.rbtPublic.TabIndex = 3;
            this.rbtPublic.Text = "public";
            this.rbtPublic.UseVisualStyleBackColor = true;
            // 
            // rbtPrivate
            // 
            this.rbtPrivate.AutoSize = true;
            this.rbtPrivate.Checked = true;
            this.rbtPrivate.Location = new System.Drawing.Point(10, 21);
            this.rbtPrivate.Name = "rbtPrivate";
            this.rbtPrivate.Size = new System.Drawing.Size(57, 17);
            this.rbtPrivate.TabIndex = 4;
            this.rbtPrivate.TabStop = true;
            this.rbtPrivate.Text = "private";
            this.rbtPrivate.UseVisualStyleBackColor = true;
            // 
            // grbClientType
            // 
            this.grbClientType.Controls.Add(this.rbtPublic);
            this.grbClientType.Controls.Add(this.rbtPrivate);
            this.grbClientType.Location = new System.Drawing.Point(66, 63);
            this.grbClientType.Name = "grbClientType";
            this.grbClientType.Size = new System.Drawing.Size(137, 71);
            this.grbClientType.TabIndex = 5;
            this.grbClientType.TabStop = false;
            this.grbClientType.Text = "client type:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(103, 153);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(103, 183);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 6;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.CadetBlue;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Location = new System.Drawing.Point(66, 274);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(137, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // AddClientFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 349);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.grbClientType);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Name = "AddClientFrm";
            this.Text = "add client";
            this.grbClientType.ResumeLayout(false);
            this.grbClientType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.RadioButton rbtPublic;
        private System.Windows.Forms.RadioButton rbtPrivate;
        private System.Windows.Forms.GroupBox grbClientType;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnOK;
    }
}