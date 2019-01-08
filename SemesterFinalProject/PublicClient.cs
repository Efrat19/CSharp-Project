using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace SemesterFinalProject
{
    [Serializable]
    class PublicClient : Person
    {
        int tickets;

        public int Tickets
        {
            get { return tickets; }
            set { tickets = value; }
        }

        public PublicClient()
        {

        }
        public PublicClient(int id,string name,int tickets):base(id,name)
        {
            this.Tickets = tickets;
        }
        /// <summary>
        /// calculates the tickets price
        /// for the specific client, play and tickets amount
        /// </summary>
        /// <param name="ticketsnum"></param>
        /// <param name="playid"></param>
        /// <returns></returns>
        public virtual double TicketsPrice(int ticketsnum, int playid)
        {
            int price = Data.play[playid].Price;
            price *= ticketsnum;
            double half = (double)price / 2;
            double discount = Tickets / 100;
            discount = (0.05 * (double)price) * (int)discount;
            return price-discount > half ? half : discount;
        }
    }
}
