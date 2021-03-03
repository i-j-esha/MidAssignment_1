using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidAssignment_1
{
    class Address  // Assosiation Has_A
    {
        private string roadNo, houseNo, city, country;

        public Address(string roadNo, string houseNo, string city, string country)
        {
            this.roadNo = roadNo;
            this.houseNo = houseNo;
            this.city = city;
            this.country = country;
        }

        public string HouseNo
        {
            set { this.houseNo = value; }
            get { return this.houseNo; }

        }

        public string RoadNo
        {
            set { this.RoadNo = value; }
            get { return this.RoadNo; }

        }

        public string City
        {
            set { this.city = value; }
            get { return this.city; }
        }

        public string Country
        {
            set { this.country = value; }
            get { return this.country; }

        }

         public string GetAddress()
        {
            return ("House No- " + this.houseNo + "\nRoad No- " + this.roadNo + "\nCity Name: " + this.city + "\nCountry Name: " + this.country);
        }

    }
}
