namespace SemesterFinalProject
{
    partial class OrderTicketsFrm
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
            this.cmbChooseShow = new System.Windows.Forms.ComboBox();
            this.cmbChooseDate = new System.Windows.Forms.ComboBox();
            this.lblChooseShow = new System.Windows.Forms.Label();
            this.lblChooseDate = new System.Windows.Forms.Label();
            this.lblChooseTickets = new System.Windows.Forms.Label();
            this.lblEnterId = new System.Windows.Forms.Label();
            this.lblChooseAge = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.nudTickets = new System.Windows.Forms.NumericUpDown();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblTotalPriceValue = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.lblChooseWorker = new System.Windows.Forms.Label();
            this.cmbChooseWorker = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbChooseShow
            // 
            this.cmbChooseShow.FormattingEnabled = true;
            this.cmbChooseShow.Location = new System.Drawing.Point(114, 212);
            this.cmbChooseShow.Name = "cmbChooseShow";
            this.cmbChooseShow.Size = new System.Drawing.Size(131, 21);
            this.cmbChooseShow.TabIndex = 50;
            this.cmbChooseShow.Visible = false;
            this.cmbChooseShow.SelectedIndexChanged += new System.EventHandler(this.cmbChooseShow_SelectedIndexChanged);
            // 
            // cmbChooseDate
            // 
            this.cmbChooseDate.FormattingEnabled = true;
            this.cmbChooseDate.Location = new System.Drawing.Point(114, 243);
            this.cmbChooseDate.Name = "cmbChooseDate";
            this.cmbChooseDate.Size = new System.Drawing.Size(131, 21);
            this.cmbChooseDate.TabIndex = 51;
            this.cmbChooseDate.Visible = false;
            // 
            // lblChooseShow
            // 
            this.lblChooseShow.AutoSize = true;
            this.lblChooseShow.Location = new System.Drawing.Point(38, 215);
            this.lblChooseShow.Name = "lblChooseShow";
            this.lblChooseShow.Size = new System.Drawing.Size(70, 13);
            this.lblChooseShow.TabIndex = 48;
            this.lblChooseShow.Text = "choose show";
            this.lblChooseShow.Visible = false;
            // 
            // lblChooseDate
            // 
            this.lblChooseDate.AutoSize = true;
            this.lblChooseDate.Location = new System.Drawing.Point(38, 246);
            this.lblChooseDate.Name = "lblChooseDate";
            this.lblChooseDate.Size = new System.Drawing.Size(69, 13);
            this.lblChooseDate.TabIndex = 49;
            this.lblChooseDate.Text = "choose date:";
            this.lblChooseDate.Visible = false;
            // 
            // lblChooseTickets
            // 
            this.lblChooseTickets.AutoSize = true;
            this.lblChooseTickets.Location = new System.Drawing.Point(38, 117);
            this.lblChooseTickets.Name = "lblChooseTickets";
            this.lblChooseTickets.Size = new System.Drawing.Size(129, 13);
            this.lblChooseTickets.TabIndex = 46;
            this.lblChooseTickets.Text = "choose amount of tickets:";
            this.lblChooseTickets.Visible = false;
            // 
            // lblEnterId
            // 
            this.lblEnterId.AutoSize = true;
            this.lblEnterId.Location = new System.Drawing.Point(40, 82);
            this.lblEnterId.Name = "lblEnterId";
            this.lblEnterId.Size = new System.Drawing.Size(45, 13);
            this.lblEnterId.TabIndex = 47;
            this.lblEnterId.Text = "enter id:";
            // 
            // lblChooseAge
            // 
            this.lblChooseAge.AutoSize = true;
            this.lblChooseAge.Location = new System.Drawing.Point(38, 143);
            this.lblChooseAge.Name = "lblChooseAge";
            this.lblChooseAge.Size = new System.Drawing.Size(66, 13);
            this.lblChooseAge.TabIndex = 45;
            this.lblChooseAge.Text = "choose age:";
            this.lblChooseAge.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(91, 79);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(98, 20);
            this.txtId.TabIndex = 54;
            // 
            // nudTickets
            // 
            this.nudTickets.Location = new System.Drawing.Point(171, 115);
            this.nudTickets.Name = "nudTickets";
            this.nudTickets.Size = new System.Drawing.Size(74, 20);
            this.nudTickets.TabIndex = 55;
            this.nudTickets.Visible = false;
            // 
            // nudAge
            // 
            this.nudAge.Location = new System.Drawing.Point(171, 141);
            this.nudAge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(74, 20);
            this.nudAge.TabIndex = 55;
            this.nudAge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAge.Visible = false;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.CadetBlue;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Location = new System.Drawing.Point(41, 305);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(204, 23);
            this.btnOK.TabIndex = 57;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(104, 173);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 58;
            this.btnSearch.Text = "search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Visible = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(38, 273);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(56, 13);
            this.lblTotalPrice.TabIndex = 60;
            this.lblTotalPrice.Text = "total price:";
            this.lblTotalPrice.Visible = false;
            // 
            // lblTotalPriceValue
            // 
            this.lblTotalPriceValue.AutoSize = true;
            this.lblTotalPriceValue.Location = new System.Drawing.Point(111, 273);
            this.lblTotalPriceValue.Name = "lblTotalPriceValue";
            this.lblTotalPriceValue.Size = new System.Drawing.Size(31, 13);
            this.lblTotalPriceValue.TabIndex = 62;
            this.lblTotalPriceValue.Text = "code";
            this.lblTotalPriceValue.Visible = false;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.CadetBlue;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Location = new System.Drawing.Point(195, 78);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(50, 23);
            this.btnLogIn.TabIndex = 63;
            this.btnLogIn.Text = "log in";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // lblChooseWorker
            // 
            this.lblChooseWorker.AutoSize = true;
            this.lblChooseWorker.Location = new System.Drawing.Point(38, 15);
            this.lblChooseWorker.Name = "lblChooseWorker";
            this.lblChooseWorker.Size = new System.Drawing.Size(91, 13);
            this.lblChooseWorker.TabIndex = 64;
            this.lblChooseWorker.Text = "choose worker id:";
            // 
            // cmbChooseWorker
            // 
            this.cmbChooseWorker.FormattingEnabled = true;
            this.cmbChooseWorker.Location = new System.Drawing.Point(135, 12);
            this.cmbChooseWorker.Name = "cmbChooseWorker";
            this.cmbChooseWorker.Size = new System.Drawing.Size(110, 21);
            this.cmbChooseWorker.TabIndex = 65;
            // 
            // OrderTicketsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 362);
            this.Controls.Add(this.cmbChooseWorker);
            this.Controls.Add(this.lblChooseWorker);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.lblTotalPriceValue);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.nudAge);
            this.Controls.Add(this.nudTickets);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.cmbChooseShow);
            this.Controls.Add(this.cmbChooseDate);
            this.Controls.Add(this.lblChooseShow);
            this.Controls.Add(this.lblChooseDate);
            this.Controls.Add(this.lblChooseTickets);
            this.Controls.Add(this.lblEnterId);
            this.Controls.Add(this.lblChooseAge);
            this.Name = "OrderTicketsFrm";
            this.Text = "orderTickets";
            this.Load += new System.EventHandler(this.orderTicketsFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbChooseShow;
        private System.Windows.Forms.ComboBox cmbChooseDate;
        private System.Windows.Forms.Label lblChooseShow;
        private System.Windows.Forms.Label lblChooseDate;
        private System.Windows.Forms.Label lblChooseTickets;
        private System.Windows.Forms.Label lblEnterId;
        private System.Windows.Forms.Label lblChooseAge;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.NumericUpDown nudTickets;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblTotalPriceValue;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Label lblChooseWorker;
        private System.Windows.Forms.ComboBox cmbChooseWorker;
    }
}