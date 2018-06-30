using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager_Apps
{
    public class Spot
    {
        //Properties
        public int Id { get; private set; }
        public int NrOfPeople { get; private set; }
        public List<User> customers { get; private set; }

        //Constructor
        public Spot(int id, int nrOfPeople)
        {
            customers = new List<User>();
            this.Id = id;
            this.NrOfPeople = nrOfPeople;
        }

        //Method

        /// <summary>
        /// Add customer to user list of this manager
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="balance"></param>
        /// <param name="email"></param>
        /// <param name="dob"></param>
        /// <param name="checkInEvent"></param>
        /// <param name="checkInCamping"></param>
        /// <param name="spotNr"></param>
        public void AddCustomer(int id, string name, decimal balance, string email, DateTime dob,
                            bool checkInEvent, bool checkInCamping, int spotNr)
        {
            customers.Add(new User(id, name, balance, email, dob, checkInEvent, checkInCamping, spotNr));
        }

        public override string ToString()
        {
            return $"Id: {Id}, People: {NrOfPeople}";
        }

    }
}
