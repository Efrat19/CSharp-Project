using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace SemesterFinalProject
{
    [Serializable]
    class Worker:Boss
    {
        int bossId;

        public int BossId
        {
            get { return bossId; }
            set { bossId = value; }
        }
        public Worker(int id, string name, int tickets, int sph,int bossId)
            : base(id, name,tickets,sph)
        {
            this.bossId = bossId;
        }
        /// <summary>
        /// calculates the worker salary
        /// </summary>
        /// <param name="hours"></param>
        /// <returns></returns>
        public override double Calc(double hours)
        {
            return hours * Sph + Tickets * 2;
        }
    }
}
