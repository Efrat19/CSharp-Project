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
    public partial class AddClientFrm : baseFrm
    {
        PublicClient pbC;

        public AddClientFrm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// clears the form
        /// </summary>
        void clear()
        {
            txtId.Text = "";
            txtName.Text = "";
        }
        /// <summary>
        /// checks the input legality
        /// </summary>
        /// <returns></returns>
        bool checkLegal()
        {
            pbC = new PublicClient();
            try
            {
                pbC.Id=int.Parse(txtId.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtId.Text = "";
                return false;
            }
            try
            {
                pbC.Name = txtName.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }
        /// <summary>
        /// creates the client object and inserts it into the clients list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (checkLegal())
            {
                if (!rbtPublic.Checked)
                    pbC = new PrivateClient(pbC.Id, pbC.Name, 0);
                Data.publicClient.Add(pbC);
                Data.Update(pbC);
                clear();
                this.Close();
            }
        }
    }
}
