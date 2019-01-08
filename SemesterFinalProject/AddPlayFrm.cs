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
    public partial class AddPlayFrm : baseFrm
    {
        Play p;

        public AddPlayFrm()
        {
            InitializeComponent();
        }

        private void AddPlayFrm_Load(object sender, EventArgs e)
        {
            lblCode.Text = Data.play.Count.ToString();
        }
        /// <summary>
        /// creates the play object and inserts it into the plays list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (checkLegal())
            {
                if (!rbtAdultes.Checked)
                    p = new Kids(p.Name, p.Minage, p.Length, int.Parse(txtPrice.Text),int.Parse(nudMaxAge.Value.ToString()));
                Data.play.Add(p);
                clear();
                this.Close();
            }
        }

        /// <summary>
        /// checks the input legality
        /// </summary>
        /// <returns></returns>
        public bool checkLegal()
        {
            p = new Play();
            try
            {
                p.Name = txtName.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            try
            {
                p.Price=int.Parse(txtPrice.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            p.Minage = int.Parse(nudMinAge.Value.ToString());
            TimeSpan ts=new TimeSpan (int.Parse(nudHours.Value.ToString()),int.Parse(nudMinutes.Value.ToString()),0);
            p.Length=ts;
            return true;
        }
        /// <summary>
        /// adapts the maxAge control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudMinAge_ValueChanged(object sender, EventArgs e)
        {
            nudMaxAge.Minimum = nudMinAge.Value + 1;
        }
        /// <summary>
        /// switches the maxAge controls visibility 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtKids_CheckedChanged(object sender, EventArgs e)
        {
            lblMaxAge.Visible = rbtKids.Checked;
            nudMaxAge.Visible = rbtKids.Checked;
        }
        /// <summary>
        /// clears the form
        /// </summary>
        void clear()
        {
            lblCode.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            nudHours.Value = 0;
            nudMinutes.Value = 0;
            nudMinAge.Value = nudMinAge.Minimum;
            nudMaxAge.Value = nudMaxAge.Minimum;
            rbtKids.Checked = true;
        }

    }
}
