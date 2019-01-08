using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SemesterFinalProject
{
    [Serializable]
    class Person
    {
        int id;
        string name;

        //prop
        public int Id
        {
            get { return id; }
            set
            {
                if (Legal.Islegal(value.ToString()))
                    id = value; 
                else
                    throw new Exception("מספר הזהות אינו חוקי");
            }
        }
        public string Name
        {
            get { return name; }
            set 
            {
                if (Legal.IsLetters(value))
                    name = value;
                else
                    throw new Exception(".הכנס שם באותיות בלבד");
            }
        }
        public Person()
        {
        }
        public Person(int id,string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
