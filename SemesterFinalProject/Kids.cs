
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace SemesterFinalProject
{
    [Serializable]
    class Kids:Play
    {
        int maxage;

        public int Maxage
        {
            get { return maxage; }
            set { maxage = value; }
        }

        public Kids(string name, int minage, TimeSpan length,int price,int maxage):base(name,minage,length,price)
        {
            this.Maxage = maxage;
        }

        /// <summary>
        /// checks the age legality
        /// </summary>
        /// <param name="age"></param>
        /// <returns></returns>
        public override bool CheckAgeFor(int age)
        {
            if (base.CheckAgeFor(age)&&this.Maxage>=age)
                return true;
            return false;
        }
    }
}
