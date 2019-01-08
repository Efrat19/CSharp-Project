using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace SemesterFinalProject
{
    [Serializable]
    class Play
    {
        int id;
        string name;
        int minage;
        TimeSpan length;
        int price;

        //properties
        public int Id
        {
            get { return id; }
            //set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Minage
        {
            get { return minage; }
            set { minage = value; }
        }
        public TimeSpan Length
        {
            get { return length; }
            set { length = value; }
        }
        public int Price
        {
            get { return price; }
            set 
            {
                if (Legal.IsNumber(value.ToString()))
                    price = value;
                else
                    throw new Exception("Insert Price in numbers");
            }
        }

        public Play()
        {
            this.id = Data.play.Count;
        }

        public Play(string name,int minage,TimeSpan length,int price)
        {
            this.id = Data.play.Count;
            this.Name = name;
            this.Minage = minage;
            this.Length = length;
            this.Price = price;
        }
        /// <summary>
        /// checks the age legality
        /// </summary>
        /// <param name="age"></param>
        /// <returns></returns>
        public virtual bool CheckAgeFor(int age)
        {
            if (this.Minage > age)
                return false;
            return true;
        }

    }
}
