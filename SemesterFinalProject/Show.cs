using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace SemesterFinalProject
{
    [Serializable]
    class Show
    {
        int id=Data.show.Count;
        int playid;
        int hallid;
        DateTime date;
        int occupancy;


        //prop
        public int Id
        {
            get { return id; }
            //set { id = value; }
        }
        public int Playid
        {
            get { return playid; }
            set { playid = value; }
        }
        public int Hallid
        {
            get { return hallid; }
            set { hallid = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public int Occupancy
        {
            get { return occupancy; }
            set { occupancy = value; }
        }

        public Show(int playid,int hallid,DateTime date)
        {
            this.Playid = playid;
            this.Hallid = hallid;
            this.Date = date;
            this.Occupancy = 0;
        }
    }
}
