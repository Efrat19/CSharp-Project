using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace SemesterFinalProject
{
    [Serializable]
    class Hall
    {
        int id=Data.hall.Count;
        int seats;

        //prop
        public int Id
        {
            get { return id; }
           // set { id = value; }
        }
        public int Seats
        {
            get { return seats; }
            set
            {
                if (Legal.IsNumber(value.ToString()))
                    seats = value;
                else
                    throw new Exception("Insert seats in numbers");
            }
        }

        public Hall(int seats)
        {
            this.Seats = seats;
        }
    }
}
