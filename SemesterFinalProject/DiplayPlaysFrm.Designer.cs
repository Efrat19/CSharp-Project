namespace SemesterFinalProject
{
    partial class DiplayPlaysFrm
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
            this.dgvPlays = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlays)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlays
            // 
            this.dgvPlays.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dgvPlays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlays.Location = new System.Drawing.Point(12, 12);
            this.dgvPlays.Name = "dgvPlays";
            this.dgvPlays.Size = new System.Drawing.Size(614, 431);
            this.dgvPlays.TabIndex = 0;
            // 
            // DiplayPlaysFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 455);
            this.Controls.Add(this.dgvPlays);
            this.Name = "DiplayPlaysFrm";
            this.Text = "DiplayPlaysFrm";
            this.Load += new System.EventHandler(this.DiplayPlaysFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlays)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlays;
    }
}