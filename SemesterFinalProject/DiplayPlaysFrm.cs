using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SemesterFinalProject
{
    /// <summary>
    /// displays plays table
    /// </summary>
    public partial class DiplayPlaysFrm : baseFrm
    {
        public DiplayPlaysFrm()
        {
            InitializeComponent();
        }

        private void DiplayPlaysFrm_Load(object sender, EventArgs e)
        {
            dgvPlays.DataSource = Data.play;
        }
    }
}
