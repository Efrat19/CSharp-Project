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
    public partial class AddHallFrm : baseFrm                   
    {
        Hall h;

        public AddHallFrm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// creates the hall object and inserts it into the halls list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            h = new Hall(int.Parse(nudSeats.Value.ToString()));
            Data.hall.Add(h);
            clear();
            this.Close();
        }

        /// <summary>
        /// clears the form
        /// </summary>
        void clear()
        {
            nudSeats.Value = nudSeats.Minimum;
            lblCodeValue.Text = "";
        }

        private void AddHallFrm_Load(object sender, EventArgs e)
        {
            lblCodeValue.Text = Data.hall.Count.ToString();
        }
    }
}
