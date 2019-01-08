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
    public partial class AddWorkerFrm : baseFrm
    {
        Boss b;
        List<Boss> bossOnly = new List<Boss>();

        public AddWorkerFrm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// creates the worker object and inserts it into the workers list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (checkLegal())
            {
                if (!rbtBoss.Checked)
                    b = new Worker(b.Id, b.Name, 0,b.Sph,int.Parse(cmbBoss.SelectedValue.ToString()));
                Data.boss.Add(b);
                Data.Update(b);
                clear();
                this.Close();
            }
        }

        private void AddWorkerFrm_Load(object sender, EventArgs e)
        {
            FillCmbBoss();
        }
        /// <summary>
        /// fills the bosses comboBox with data from the bossOnly list
        /// </summary>
        void FillCmbBoss()
        {
            cmbBoss.DataSource = null;
            bossOnly.Clear();
            for (int i = 0; i < Data.boss.Count; i++)
                if (!(Data.boss[i] is Worker))
                    bossOnly.Add(Data.boss[i]);
            cmbBoss.DataSource = bossOnly;
            cmbBoss.DisplayMember = "name";
            cmbBoss.ValueMember = "id";
        }

        /// <summary>
        /// checks the input legality
        /// </summary>
        /// <returns></returns>
        bool checkLegal()
        {
            b=new Boss ();
            try
            {
                b.Id = int.Parse(txtId.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtId.Text = "";
                return false;
            }
            try
            {
                b.Name = txtName.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtName.Text = "";
                return false;
            }
            try
            {
                b.Sph = int.Parse(txtSph.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtSph.Text = "";
                return false;
            }
            return true;
        }
        /// <summary>
        /// clears the form
        /// </summary>
        void clear()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtSph.Text = "";
        }
        /// <summary>
        /// switches the boss controls visibility 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtWorker_CheckedChanged(object sender, EventArgs e)
        {
            lblBoss.Visible = rbtWorker.Checked;
            cmbBoss.Visible = rbtWorker.Checked;
        }
    }
}
