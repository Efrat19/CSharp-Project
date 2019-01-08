namespace SemesterFinalProject
{
    partial class AddShowFrm
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
            this.lblCode = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblChoosePlay = new System.Windows.Forms.Label();
            this.cmbPlay = new System.Windows.Forms.ComboBox();
            this.lblPlayCode = new System.Windows.Forms.Label();
            this.lblPlayCodeValue = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblChooseDate = new System.Windows.Forms.Label();
            this.cmbChoosehall = new System.Windows.Forms.ComboBox();
            this.lblChoosehall = new System.Windows.Forms.Label();
            this.lblChosseTime = new System.Windows.Forms.Label();
            this.cmbChooseTime = new System.Windows.Forms.ComboBox();
            this.lblSeatsNum = new System.Windows.Forms.Label();
            this.lblSeatsNumValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.CadetBlue;
            this.btnOK.Enabled = false;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Location = new System.Drawing.Point(27, 273);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(177, 23);
            this.btnOK.TabIndex = 38;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(64, 10);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(31, 13);
            this.lblCode.TabIndex = 27;
            this.lblCode.Text = "code";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(11, 10);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(62, 13);
            this.lblId.TabIndex = 28;
            this.lblId.Text = "show code:";
            // 
            // lblChoosePlay
            // 
            this.lblChoosePlay.AutoSize = true;
            this.lblChoosePlay.Location = new System.Drawing.Point(24, 72);
            this.lblChoosePlay.Name = "lblChoosePlay";
            this.lblChoosePlay.Size = new System.Drawing.Size(64, 13);
            this.lblChoosePlay.TabIndex = 39;
            this.lblChoosePlay.Text = "choose play";
            // 
            // cmbPlay
            // 
            this.cmbPlay.FormattingEnabled = true;
            this.cmbPlay.Location = new System.Drawing.Point(85, 69);
            this.cmbPlay.Name = "cmbPlay";
            this.cmbPlay.Size = new System.Drawing.Size(121, 21);
            this.cmbPlay.TabIndex = 40;
            this.cmbPlay.SelectedIndexChanged += new System.EventHandler(this.cmbPlay_SelectedIndexChanged);
            // 
            // lblPlayCode
            // 
            this.lblPlayCode.AutoSize = true;
            this.lblPlayCode.Location = new System.Drawing.Point(23, 93);
            this.lblPlayCode.Name = "lblPlayCode";
            this.lblPlayCode.Size = new System.Drawing.Size(56, 13);
            this.lblPlayCode.TabIndex = 28;
            this.lblPlayCode.Text = "play code:";
            // 
            // lblPlayCodeValue
            // 
            this.lblPlayCodeValue.AutoSize = true;
            this.lblPlayCodeValue.Location = new System.Drawing.Point(77, 93);
            this.lblPlayCodeValue.Name = "lblPlayCodeValue";
            this.lblPlayCodeValue.Size = new System.Drawing.Size(13, 13);
            this.lblPlayCodeValue.TabIndex = 27;
            this.lblPlayCodeValue.Text = "0";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(85, 121);
            this.dtpDate.MinDate = new System.DateTime(2018, 3, 5, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(121, 20);
            this.dtpDate.TabIndex = 41;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // lblChooseDate
            // 
            this.lblChooseDate.AutoSize = true;
            this.lblChooseDate.Location = new System.Drawing.Point(22, 121);
            this.lblChooseDate.Name = "lblChooseDate";
            this.lblChooseDate.Size = new System.Drawing.Size(66, 13);
            this.lblChooseDate.TabIndex = 39;
            this.lblChooseDate.Text = "choose date";
            // 
            // cmbChoosehall
            // 
            this.cmbChoosehall.FormattingEnabled = true;
            this.cmbChoosehall.Location = new System.Drawing.Point(85, 174);
            this.cmbChoosehall.Name = "cmbChoosehall";
            this.cmbChoosehall.Size = new System.Drawing.Size(121, 21);
            this.cmbChoosehall.TabIndex = 40;
            this.cmbChoosehall.Visible = false;
            this.cmbChoosehall.SelectedIndexChanged += new System.EventHandler(this.cmbChoosehall_SelectedIndexChanged);
            // 
            // lblChoosehall
            // 
            this.lblChoosehall.AutoSize = true;
            this.lblChoosehall.Location = new System.Drawing.Point(22, 177);
            this.lblChoosehall.Name = "lblChoosehall";
            this.lblChoosehall.Size = new System.Drawing.Size(61, 13);
            this.lblChoosehall.TabIndex = 39;
            this.lblChoosehall.Text = "choose hall";
            this.lblChoosehall.Visible = false;
            // 
            // lblChosseTime
            // 
            this.lblChosseTime.AutoSize = true;
            this.lblChosseTime.Location = new System.Drawing.Point(22, 150);
            this.lblChosseTime.Name = "lblChosseTime";
            this.lblChosseTime.Size = new System.Drawing.Size(64, 13);
            this.lblChosseTime.TabIndex = 39;
            this.lblChosseTime.Text = "choose time";
            this.lblChosseTime.Visible = false;
            // 
            // cmbChooseTime
            // 
            this.cmbChooseTime.FormattingEnabled = true;
            this.cmbChooseTime.Location = new System.Drawing.Point(85, 147);
            this.cmbChooseTime.Name = "cmbChooseTime";
            this.cmbChooseTime.Size = new System.Drawing.Size(121, 21);
            this.cmbChooseTime.TabIndex = 40;
            this.cmbChooseTime.Visible = false;
            this.cmbChooseTime.SelectedIndexChanged += new System.EventHandler(this.cmbChooseTime_SelectedIndexChanged);
            // 
            // lblSeatsNum
            // 
            this.lblSeatsNum.AutoSize = true;
            this.lblSeatsNum.Location = new System.Drawing.Point(54, 204);
            this.lblSeatsNum.Name = "lblSeatsNum";
            this.lblSeatsNum.Size = new System.Drawing.Size(35, 13);
            this.lblSeatsNum.TabIndex = 28;
            this.lblSeatsNum.Text = "seats.";
            this.lblSeatsNum.Visible = false;
            // 
            // lblSeatsNumValue
            // 
            this.lblSeatsNumValue.AutoSize = true;
            this.lblSeatsNumValue.Location = new System.Drawing.Point(24, 204);
            this.lblSeatsNumValue.Name = "lblSeatsNumValue";
            this.lblSeatsNumValue.Size = new System.Drawing.Size(31, 13);
            this.lblSeatsNumValue.TabIndex = 27;
            this.lblSeatsNumValue.Text = "code";
            this.lblSeatsNumValue.Visible = false;
            // 
            // AddShowFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 331);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cmbChooseTime);
            this.Controls.Add(this.cmbChoosehall);
            this.Controls.Add(this.cmbPlay);
            this.Controls.Add(this.lblChosseTime);
            this.Controls.Add(this.lblChooseDate);
            this.Controls.Add(this.lblChoosehall);
            this.Controls.Add(this.lblChoosePlay);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblSeatsNumValue);
            this.Controls.Add(this.lblPlayCodeValue);
            this.Controls.Add(this.lblSeatsNum);
            this.Controls.Add(this.lblPlayCode);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblId);
            this.Name = "AddShowFrm";
            this.Text = "Add New Show";
            this.Load += new System.EventHandler(this.AddShowFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblChoosePlay;
        private System.Windows.Forms.ComboBox cmbPlay;
        private System.Windows.Forms.Label lblPlayCode;
        private System.Windows.Forms.Label lblPlayCodeValue;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblChooseDate;
        private System.Windows.Forms.ComboBox cmbChoosehall;
        private System.Windows.Forms.Label lblChoosehall;
        private System.Windows.Forms.Label lblChosseTime;
        private System.Windows.Forms.ComboBox cmbChooseTime;
        private System.Windows.Forms.Label lblSeatsNum;
        private System.Windows.Forms.Label lblSeatsNumValue;
    }
}