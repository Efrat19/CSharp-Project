using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace SemesterFinalProject
{
    [Serializable]
    class Boss:Person
    {
        int tickets;
        int sph;

        //prop
        public int Tickets
        {
            get { return tickets; }
            set { tickets = value; }
        }
        public int Sph
        {
            get { return sph; }
            set
            {
                if (Legal.IsNumber(value.ToString()))
                    sph = value;
                else
                    throw new Exception("Insert selery in numbers"); 
            }
        }

        public Boss()
        {

        }
        public Boss(int id,string name, int tickets, int sph):base(id,name)
        {
            this.Tickets=tickets;
            this.Sph = sph;
        }
        /// <summary>
        /// calculates the boss salary
        /// </summary>
        /// <param name="hours"></param>
        /// <returns></returns>
        public virtual double Calc(double hours)
        {
            double salary=Sph*hours+tickets;
            return tickets>1000?salary+100:salary;
        }
    }
}
