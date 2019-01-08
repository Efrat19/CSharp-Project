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
    public partial class AddShowFrm : baseFrm
    {
        bool[,] isFull;
        DateTime start;
        DateTime end;
        int intLength;
        TimeSpan len;
        Show sh;

        public AddShowFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// initials the hours boolean matrix in false 
        /// </summary>
        public void FalseMat()
        {
            for (int i = 0; i < Data.hall.Count; i++)
                for (int j = 0; j < 56; j++)
                    isFull[i, j] = false;
        }
        private void AddShowFrm_Load(object sender, EventArgs e)
        {
            cmbPlay.SelectedIndexChanged -= cmbPlay_SelectedIndexChanged;
            dtpDate.MinDate = DateTime.Today;
            lblCode.Text = Data.show.Count.ToString();
            isFull = new bool[Data.hall.Count, 56];
            FalseMat();
            FillCmbPlay();
            cmbPlay.SelectedIndexChanged += cmbPlay_SelectedIndexChanged;
        }
        /// <summary>
        /// fills the plays comboBox with the plays list
        /// </summary>
        void FillCmbPlay()
        {
            cmbPlay.DataSource = Data.play;
            cmbPlay.DisplayMember = "name";
            cmbPlay.ValueMember = "id";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">id of a specific play from the plays list</param>
        /// <returns>the specific play length</returns>
        private TimeSpan FindLength(int id)
        {
            for (int i = 0; i < Data.play.Count; i++)
            {
                if (Data.play[i].Id == id)
                    return Data.play[i].Length;
            }
            return TimeSpan.Parse("0");
        }
        /// <summary>
        /// fills the hours boolean matrix "isFull" with full hours from the shows list
        /// adds the unoccupied hours to the hours comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            FalseMat();
            for (int i = 0; i < Data.show.Count; i++)
            {
                if (Data.show[i].Date.ToShortDateString().Equals(dtpDate.Value.ToShortDateString()))
                {
                    start = Data.show[i].Date;
                    end=start.Add(FindLength(Data.show[i].Playid));
                    for (int j = (start.Hour-8)*4+start.Minute/15; j <= (end.Hour-8)*4+end.Minute/15&&j<56; j++)
                    {
                        isFull[Data.show[i].Hallid,j]=true;
                    }
                }
            }
            len=FindLength(int.Parse(lblPlayCodeValue.Text));
            intLength = len.Hours*4+len.Minutes/15+1;
            cmbChooseTime.Items.Clear();
            for (int j = 0; j < 56-intLength; j++)
            {
                for (int i = 0; i < Data.hall.Count; i++)
                {
                    int k;
                    for (k = j; k<=j+intLength; k++)
                    {
                        if (isFull[i, k])
                            break;
                    }
                    if (k == intLength+j+1)
                    {
                        addTime(j);
                        break;
                    }
                }
            }
            lblChosseTime.Visible = true;
            cmbChooseTime.Visible = true;
        }
        /// <summary>
        /// adds the unoccupied hours to the hours comboBox
        /// </summary>
        /// <param name="time"></param>
        void addTime(int time)
        {
            DateTime dt = new DateTime(2018,5,3,time/4+8,(time%4)*15,0);
            cmbChooseTime.Items.Add(dt.ToShortTimeString());
        }
        /// <summary>
        /// fills the hall comboBox with the unoccupied halls at the selected date and time 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbChooseTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime tmp=DateTime.Parse(cmbChooseTime.SelectedItem.ToString());
            int start=(tmp.Hour-8)*4+tmp.Minute/15;
            cmbChoosehall.Items.Clear();
            for (int i = 0; i <  Data.hall.Count; i++)
            {
                int j;
                for (j = start; j < start+intLength; j++)
                {
                    if (isFull[i, j])
                        break;
                }
                if (j == intLength+start)
                    cmbChoosehall.Items.Add(i);
            }
            lblChoosehall.Visible = true;
            cmbChoosehall.Visible = true;
        }
        /// <summary>
        /// shows thw seats labels and the confirm button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbChoosehall_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSeatsNumValue.Text = Data.hall[int.Parse(cmbChoosehall.SelectedItem.ToString())].Seats.ToString();
            lblSeatsNum.Visible = true;
            lblSeatsNumValue.Visible = true;
            btnOK.Enabled = true;
        }
        /// <summary>
        /// creates the show object and inserts it into the shows list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            DateTime finalTime=DateTime.Parse(cmbChooseTime.SelectedItem.ToString());

            DateTime final=new DateTime (dtpDate.Value.Year,dtpDate.Value.Month,dtpDate.Value.Day,finalTime.Hour,finalTime.Minute,finalTime.Second);
            sh = new Show(int.Parse(lblPlayCodeValue.Text), int.Parse(cmbChoosehall.SelectedItem.ToString()), final);
            Data.show.Add(sh);
            clear();
            this.Close();
        }
        /// <summary>
        /// shows the selected play id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbPlay_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPlayCodeValue.Text = cmbPlay.SelectedIndex.ToString();
        }
        /// <summary>
        /// clears the form
        /// </summary>
        void clear()
        {
            lblCode.Text = "";
            cmbChoosehall.Text = "";
            cmbChooseTime.Text = "";
            dtpDate.Value = DateTime.Today;
            lblSeatsNumValue.Text = "";
            lblChosseTime.Visible = false;
            cmbChooseTime.Visible = false;
            lblChoosehall.Visible = false;
            cmbChoosehall.Visible = false;
            lblSeatsNum.Visible = false;
            lblSeatsNumValue.Visible = false;
            btnOK.Enabled = false;
        }
    }
}
