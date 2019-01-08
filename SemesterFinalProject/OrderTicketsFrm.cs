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
    public partial class OrderTicketsFrm : baseFrm
    {
        int clientIndex;
        public OrderTicketsFrm()
        {
            InitializeComponent();
        }
        List<Worker> workerOnly = new List<Worker>();
        List<Play> legalPlayOnly = new List<Play>();
        private void orderTicketsFrm_Load(object sender, EventArgs e)
        {
            this.Clear();
            FillCmbWorker();
        }

        /// <summary>
        /// boolean function. Checks if client id exists in clients list. 
        /// </summary>
        /// <returns> returns true if exsits, false if not.</returns>
        public bool CheckInList()
        {
            for (int i = 0; i < Data.publicClient.Count; i++)
                if (Data.publicClient[i].Id == int.Parse(txtId.Text))
                {
                    clientIndex = i;
                    return true;
                }
            MessageBox.Show("unsigned ID.");
            txtId.Text = "";
            return false;
        }
        /// <summary>
        /// fills the workers comboBox with data from the workerOnly list
        /// </summary>
        public void FillCmbWorker()
        {
            workerOnly.Clear();
            cmbChooseWorker.DataSource = null;
            for (int i = 0; i < Data.boss.Count; i++)
            {
                if (Data.boss[i] is Worker)
                    workerOnly.Add(Data.boss[i] as Worker);
            }
            cmbChooseWorker.DataSource = workerOnly;
            cmbChooseWorker.DisplayMember = "name";
            cmbChooseWorker.ValueMember = "id";
        }

        /// <summary>
        /// checks the id and switches the choosing controls visibility
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtId.Text!=""&&CheckInList())
            {
                lblChooseTickets.Visible = true;
                nudTickets.Visible = true;
                lblChooseAge.Visible = true;
                nudAge.Visible = true;
                btnSearch.Visible = true;
            }
        }
        /// <summary>
        /// checks the hall occupancy for the selected show
        /// </summary>
        /// <param name="tickets"></param>
        /// <param name="showId"></param>
        /// <returns></returns>
        public bool CheckOccupied(int tickets, int showId)
        {
            if (Data.show[showId].Occupancy + tickets <= Data.hall[Data.show[showId].Hallid].Seats)
                return true;
            return false;
        }
        /// <summary>
        /// fills the plays comboBox with data from the legalPlayOnly list
        /// </summary>
        public void FillCmbShow()
        {
            legalPlayOnly.Clear();
            for (int i= 0; i < Data.show.Count; i++)
                if (Data.play[Data.show[i].Playid].CheckAgeFor(int.Parse(nudAge.Value.ToString()))&& CheckOccupied(int.Parse(nudTickets.Value.ToString()), Data.show[i].Id))
                    addShow(Data.show[i].Playid);
            cmbChooseShow.DataSource = legalPlayOnly;
            cmbChooseShow.DisplayMember = "name";
            cmbChooseShow.ValueMember = "id";
        }
        /// <summary>
        /// adds a play to the legalPlayOnly list
        /// </summary>
        /// <param name="playId"></param>
        void addShow(int playId)
        {
            for (int i = 0; i < legalPlayOnly.Count; i++)
            {

                if ((legalPlayOnly[i]).Id == playId)
                    return;
            }
            legalPlayOnly.Add(Data.play[playId]);
        }

        /// <summary>
        /// fills the dates comboBox with the show dates
        /// </summary>
        public void FillCmbDate()
        {
            List<DateTime> dates = new List<DateTime>();
            Play pl = cmbChooseShow.SelectedItem as Play;
            for (int i = 0; i < Data.show.Count; i++)
                if (pl.Id == Data.show[i].Playid && CheckOccupied(int.Parse(nudTickets.Value.ToString()), Data.show[i].Id))
                    dates.Add(Data.show[i].Date);
            dates.Sort();
            cmbChooseDate.DataSource = dates;
        }

        /// <summary>
        /// switches the choosing controls visibility
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            cmbChooseShow.SelectedIndexChanged += cmbChooseShow_SelectedIndexChanged;
            FillCmbShow();
            cmbChooseDate.SelectedItem = null;
            lblTotalPrice.Visible = true;
            cmbChooseDate.Enabled = false;
            cmbChooseDate.Visible = true;
            cmbChooseShow.Visible = true;
            lblChooseDate.Visible = true;
            lblChooseShow.Visible = true;
            cmbChooseShow.SelectedIndexChanged += cmbChooseShow_SelectedIndexChanged;
        }

        /// <summary>
        /// enables the date choosing comboBox
        /// calculates and displays the price
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbChooseShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCmbDate();
            cmbChooseDate.Enabled = true;
            double price = Data.publicClient[clientIndex].TicketsPrice(int.Parse(nudTickets.Value.ToString()),((Play)cmbChooseShow.SelectedItem).Id);
            lblTotalPriceValue.Text = price.ToString();
            lblTotalPriceValue.Visible = true;
        }

        /// <summary>
        /// updates the client, the show, the worker and the boss details,
        /// depending on the tickets num
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Data.show.Count; i++)
                if (Data.show[i].Date == DateTime.Parse(cmbChooseDate.SelectedItem.ToString()))
                {
                    Data.show[i].Occupancy += int.Parse(nudTickets.Value.ToString());
                    break;
                }
            Data.publicClient[clientIndex].Tickets += int.Parse(nudTickets.Value.ToString());
            for(int i=0;i<Data.boss.Count;i++)
                if(int.Parse(cmbChooseWorker.SelectedValue.ToString())==Data.boss[i].Id)
                {
                    Data.boss[i].Tickets += int.Parse(nudTickets.Value.ToString());
                    for (int j = 0; j < Data.boss.Count; j++)
                        if (!(Data.boss[j] is Worker) && ((Worker)Data.boss[i]).BossId == Data.boss[j].Id)
                        {
                            Data.boss[j].Tickets += int.Parse(nudTickets.Value.ToString());
                            break;
                        }
                    break;
                }
            for(int i=0;i<Data.boss.Count;i++)
                if (Data.boss[i] is Worker &&((Worker)Data.boss[i]).BossId == int.Parse(cmbChooseWorker.SelectedValue.ToString()))
                {
                    Data.boss[i].Tickets += int.Parse(nudTickets.Value.ToString());
                    break;
                }
            this.Clear();
            this.Close();
        }

        /// <summary>
        /// clears the form
        /// </summary>
        public void Clear()
        {
            btnSearch.Visible = false;
            lblChooseTickets.Visible = false;
            nudTickets.Visible = false;
            nudTickets.Value = 1;
            lblChooseAge.Visible = false;
            nudAge.Visible = false;
            nudAge.Value = 1;
            lblTotalPriceValue.Text = "";
            lblTotalPriceValue.Visible = false;
            lblTotalPrice.Visible = false;
            cmbChooseDate.Visible = false;
            cmbChooseShow.Visible = false;
            lblChooseDate.Visible = false;
            lblChooseShow.Visible = false;
            txtId.Text = "";
        }


    }

}
