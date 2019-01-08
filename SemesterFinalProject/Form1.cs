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
    public partial class Form1 : Form
    {
        AddClientFrm addClient = new AddClientFrm();
        AddWorkerFrm addWorker = new AddWorkerFrm();
        AddPlayFrm addPlay = new AddPlayFrm();
        AddShowFrm addShow = new AddShowFrm();
        AddHallFrm addHall = new AddHallFrm();
        OrderTicketsFrm orderTickets = new OrderTicketsFrm();
        CalcSalaryFrm calcSalary = new CalcSalaryFrm();
        DisplayShowsFrm displayShows = new DisplayShowsFrm();
        DiplayPlaysFrm displayPlays = new DiplayPlaysFrm();
        AboutFrm about = new AboutFrm();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnAddPlay_Click(object sender, EventArgs e)
        {
            addPlay.ShowDialog();
        }

        private void btnAddShow_Click(object sender, EventArgs e)
        {
            addShow.ShowDialog();
        }

        private void btnAddhall_Click(object sender, EventArgs e)
        {
            addHall.ShowDialog();
        }

        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            addWorker.ShowDialog();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            addClient.ShowDialog();
        }

        private void btnOrderTickets_Click(object sender, EventArgs e)
        {
            orderTickets.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calcSalary.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            displayShows.ShowDialog();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            about.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            displayPlays.ShowDialog();
        }
    }
}
