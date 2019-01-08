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
    /// displays shows table
    /// </summary>
    public partial class DisplayShowsFrm : baseFrm
    {
        public DisplayShowsFrm()
        {
            InitializeComponent();
        }

        private void DisplayShowsFrm_Load(object sender, EventArgs e)
        {
            dgvShows.DataSource = Data.show;
        }
    }
}
