using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace SemesterFinalProject
{
    /// <summary>
    /// the static class Data contains the data lists, and the open/save functions
    /// note:
    /// the static Play list contains both Play and Kids objects
    /// the static Boss list contains both Boss and Worker objects
    /// the static PublicClient list contains both PublicClient and PrivateClient objects
    /// </summary>
    class Data : IEnumerable, IEnumerator
    {
        /// <summary>
        /// the static Play list contains both Play and Kids objects
        /// </summary>
        public static List<Play> play=new List<Play>();
        public static List<Show> show=new List<Show>();
        /// <summary>
        /// the static PublicClient list contains both PublicClient and PrivateClient objects
        /// </summary>
        public static List<PublicClient> publicClient=new List<PublicClient>();
        /// <summary>
        /// the static Boss list contains both Boss and Worker objects
        /// </summary>
        public static List<Boss> boss=new List<Boss>();
        public static List<Hall> hall=new List<Hall>();
        public static List<Person> person = new List<Person>();
        public static BinaryFormatter bf = new BinaryFormatter();
        public static string path = @"files\";

        /// <summary>
        /// loads the lists into files 
        /// </summary>
        public static void SaveData()
        {
            FileStream outstream = new FileStream(path+"play",FileMode.OpenOrCreate,FileAccess.Write);
            bf.Serialize(outstream, play);
            outstream.Close();
            outstream = new FileStream(path + "show", FileMode.OpenOrCreate, FileAccess.Write);
            bf.Serialize(outstream, show);
            outstream.Close();
            outstream = new FileStream(path + "hall", FileMode.OpenOrCreate, FileAccess.Write);
            bf.Serialize(outstream, hall);
            outstream.Close();
            outstream = new FileStream(path + "boss", FileMode.OpenOrCreate, FileAccess.Write);
            bf.Serialize(outstream, boss);
            outstream.Close();
            outstream = new FileStream(path + "publicClient", FileMode.OpenOrCreate, FileAccess.Write);
            bf.Serialize(outstream, publicClient);
            outstream.Close();
        }
        /// <summary>
        /// checks for the files directory existance-
        /// creates it or calls the DoOpen function to load the files into the lists
        /// </summary>
        public static void OpenData()
        {
            DirectoryInfo di = new DirectoryInfo(@"\files");
            if (di.Exists)
                DoOpen();
            else
            {
                di.Create(); 
            }
        }
        /// <summary>
        /// loads the files into the lists
        /// </summary>
        public static void DoOpen()
        {
            FileStream instream = new FileStream(path+"play", FileMode.Open);
            play = (List<Play>)bf.Deserialize(instream);
            instream.Close();
            instream = new FileStream(path+"show", FileMode.Open);
            show = (List<Show>)bf.Deserialize(instream);
            instream.Close();
            instream = new FileStream(path+"publicClient", FileMode.Open);
            publicClient = (List<PublicClient>)bf.Deserialize(instream);
            instream.Close();
            instream = new FileStream(path+"boss", FileMode.Open);
            boss = (List<Boss>)bf.Deserialize(instream);
            instream.Close();
            instream = new FileStream(path+"hall", FileMode.Open);
            hall = (List<Hall>)bf.Deserialize(instream);
            instream.Close();

            person.AddRange(publicClient);
            person.AddRange(boss);
        }

        int iCurrent = -1;

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }

        public Object Current
        {
            get
            {
                return person[iCurrent];
            }
        }

        public bool MoveNext()
        {
            if (iCurrent < person.Count())
            {
                iCurrent++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            iCurrent = -1;
        }

        /// <summary>
        /// adds a person object (worker or client) to the person list
        /// </summary>
        /// <param name="p"></param>
        public static void Update(Person p)
        {
            person.Add(p);
        }
    }
}
