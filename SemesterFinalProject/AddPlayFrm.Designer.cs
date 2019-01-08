namespace SemesterFinalProject
{
    partial class AddPlayFrm
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
            this.grbClientType = new System.Windows.Forms.GroupBox();
            this.rbtAdultes = new System.Windows.Forms.RadioButton();
            this.rbtKids = new System.Windows.Forms.RadioButton();
            this.lblSph = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.nudMinAge = new System.Windows.Forms.NumericUpDown();
            this.nudHours = new System.Windows.Forms.NumericUpDown();
            this.nudMinutes = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblMaxAge = new System.Windows.Forms.Label();
            this.nudMaxAge = new System.Windows.Forms.NumericUpDown();
            this.grbClientType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxAge)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.CadetBlue;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Location = new System.Drawing.Point(58, 272);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(137, 23);
            this.btnOK.TabIndex = 23;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(95, 138);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 20;
            // 
            // grbClientType
            // 
            this.grbClientType.Controls.Add(this.rbtAdultes);
            this.grbClientType.Controls.Add(this.rbtKids);
            this.grbClientType.Location = new System.Drawing.Point(58, 61);
            this.grbClientType.Name = "grbClientType";
            this.grbClientType.Size = new System.Drawing.Size(137, 71);
            this.grbClientType.TabIndex = 19;
            this.grbClientType.TabStop = false;
            this.grbClientType.Text = "audience:";
            // 
            // rbtAdultes
            // 
            this.rbtAdultes.AutoSize = true;
            this.rbtAdultes.Location = new System.Drawing.Point(10, 48);
            this.rbtAdultes.Name = "rbtAdultes";
            this.rbtAdultes.Size = new System.Drawing.Size(53, 17);
            this.rbtAdultes.TabIndex = 3;
            this.rbtAdultes.Text = "adults";
            this.rbtAdultes.UseVisualStyleBackColor = true;
            // 
            // rbtKids
            // 
            this.rbtKids.AutoSize = true;
            this.rbtKids.Checked = true;
            this.rbtKids.Location = new System.Drawing.Point(10, 25);
            this.rbtKids.Name = "rbtKids";
            this.rbtKids.Size = new System.Drawing.Size(44, 17);
            this.rbtKids.TabIndex = 4;
            this.rbtKids.TabStop = true;
            this.rbtKids.Text = "kids";
            this.rbtKids.UseVisualStyleBackColor = true;
            this.rbtKids.CheckedChanged += new System.EventHandler(this.rbtKids_CheckedChanged);
            // 
            // lblSph
            // 
            this.lblSph.AutoSize = true;
            this.lblSph.Location = new System.Drawing.Point(49, 218);
            this.lblSph.Name = "lblSph";
            this.lblSph.Size = new System.Drawing.Size(44, 13);
            this.lblSph.TabIndex = 16;
            this.lblSph.Text = "min age";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(55, 166);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(36, 13);
            this.lblLength.TabIndex = 17;
            this.lblLength.Text = "length";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(60, 141);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(33, 13);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "name";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(56, 13);
            this.lblId.TabIndex = 15;
            this.lblId.Text = "play code:";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(65, 9);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(31, 13);
            this.lblCode.TabIndex = 15;
            this.lblCode.Text = "code";
            // 
            // nudMinAge
            // 
            this.nudMinAge.Location = new System.Drawing.Point(95, 215);
            this.nudMinAge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMinAge.Name = "nudMinAge";
            this.nudMinAge.Size = new System.Drawing.Size(100, 20);
            this.nudMinAge.TabIndex = 25;
            this.nudMinAge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMinAge.ValueChanged += new System.EventHandler(this.nudMinAge_ValueChanged);
            // 
            // nudHours
            // 
            this.nudHours.Location = new System.Drawing.Point(95, 164);
            this.nudHours.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudHours.Name = "nudHours";
            this.nudHours.Size = new System.Drawing.Size(42, 20);
            this.nudHours.TabIndex = 25;
            // 
            // nudMinutes
            // 
            this.nudMinutes.Increment = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudMinutes.Location = new System.Drawing.Point(154, 164);
            this.nudMinutes.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.nudMinutes.Name = "nudMinutes";
            this.nudMinutes.Size = new System.Drawing.Size(41, 20);
            this.nudMinutes.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = ":";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(60, 191);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(30, 13);
            this.lblPrice.TabIndex = 16;
            this.lblPrice.Text = "price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(96, 188);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 20;
            // 
            // lblMaxAge
            // 
            this.lblMaxAge.AutoSize = true;
            this.lblMaxAge.Location = new System.Drawing.Point(49, 244);
            this.lblMaxAge.Name = "lblMaxAge";
            this.lblMaxAge.Size = new System.Drawing.Size(47, 13);
            this.lblMaxAge.TabIndex = 16;
            this.lblMaxAge.Text = "max age";
            this.lblMaxAge.UseWaitCursor = true;
            // 
            // nudMaxAge
            // 
            this.nudMaxAge.Location = new System.Drawing.Point(95, 242);
            this.nudMaxAge.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudMaxAge.Name = "nudMaxAge";
            this.nudMaxAge.Size = new System.Drawing.Size(100, 20);
            this.nudMaxAge.TabIndex = 26;
            this.nudMaxAge.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // AddPlayFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 356);
            this.Controls.Add(this.nudMaxAge);
            this.Controls.Add(this.nudMinutes);
            this.Controls.Add(this.nudHours);
            this.Controls.Add(this.nudMinAge);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblMaxAge);
            this.Controls.Add(this.grbClientType);
            this.Controls.Add(this.lblSph);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblId);
            this.Name = "AddPlayFrm";
            this.Text = "AddPlayFrm";
            this.Load += new System.EventHandler(this.AddPlayFrm_Load);
            this.grbClientType.ResumeLayout(false);
            this.grbClientType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox grbClientType;
        private System.Windows.Forms.RadioButton rbtAdultes;
        private System.Windows.Forms.RadioButton rbtKids;
        private System.Windows.Forms.Label lblSph;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.NumericUpDown nudMinAge;
        private System.Windows.Forms.NumericUpDown nudHours;
        private System.Windows.Forms.NumericUpDown nudMinutes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblMaxAge;
        private System.Windows.Forms.NumericUpDown nudMaxAge;
    }
}