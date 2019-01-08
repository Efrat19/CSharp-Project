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
    public partial class CalcSalaryFrm : baseFrm
    {
        public CalcSalaryFrm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// checks the input legality
        /// </summary>
        /// <returns></returns>
        public bool checklegal()
        {
            foreach (var item in Data.person)
            {
                if (item.Id == int.Parse(txtId.Text))
                    return Legal.IsNumber(txtHours.Text);
            }
            return false;
        }
        /// <summary>
        /// clears the form
        /// </summary>
        public void clear()
        {
            txtHours.Text = "";
            txtId.Text = "";
        }
        /// <summary>
        /// calculates and shows the employee salary
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Legal.IsNumber(txtHours.Text))
            {
                for (int i = 0; i < Data.boss.Count; i++)
                    if (Data.boss[i].Id.ToString().Equals(txtId.Text))
                    {
                        double sal = Data.boss[i].Calc(double.Parse(txtHours.Text));
                        MessageBox.Show("Dear " + Data.boss[i].Name + "\nyour salary is " + sal + ".\nHave a great day!");
                        clear();
                        Close();
                        return;
                    }
                MessageBox.Show("worker could not be found, please try again");
                txtId.Text = "";
            }
            else
            {
                MessageBox.Show("illegal salary, please try again");
                txtHours.Text = "";
            }
        }
    }
}
