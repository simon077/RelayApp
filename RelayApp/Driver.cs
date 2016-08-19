using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelayApp
{
    class Driver
    {
        private DateTime minDate = new DateTime(1900, 01, 01);
        private string firstName { get; set; }
        private string surname { get; set; }
        private string occupation { get; set; }
        private DateTime dateOfBirth { get; set; }
        private string numberOfClaims { get; set; }
        private DateTime claim1Date { get; set; }
        private DateTime claim2Date { get; set; }
        private DateTime claim3Date { get; set; }
        private DateTime claim4Date { get; set; }
        private DateTime claim5Date { get; set; }

        //Constructor

        public Driver() { }

        public Driver(string firstName, string surname, string occupation, DateTime dateOfBirth, string numberOfClaims, DateTime claim1Date, DateTime claim2Date, DateTime claim3Date, DateTime claim4Date, DateTime claim5Date)
        {
            this.firstName = firstName;
            this.surname = surname;
            this.occupation = occupation;
            this.dateOfBirth = dateOfBirth;
            this.numberOfClaims = numberOfClaims;
            this.claim1Date = claim1Date;
            this.claim2Date = claim2Date;
            this.claim3Date = claim3Date;
            this.claim4Date = claim4Date;
            this.claim5Date = claim5Date;


        }

        // Gets/Sets
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string Occupation
        {
            get { return occupation; }
            set { occupation = value; }
        }
        public DateTime DateOfBirth
        {
            get 
            {
                if(dateOfBirth == default(DateTime))
                {
                    return minDate;
                }
                else
                {
                    return dateOfBirth; 
                }
            }
            set { dateOfBirth = value; }
        }
        public string NumberOfClaims
        {
            get 
            {
                if (numberOfClaims != "0" && numberOfClaims != "1" && numberOfClaims != "2" && numberOfClaims != "3" && numberOfClaims != "4" && numberOfClaims != "5")
                {
                    return "0";
                }
                else
                {
                    return numberOfClaims; 
                }
            }
            set { numberOfClaims = value; }
        }
            public DateTime Claim1Date
        {
            get
            {
                if (claim1Date == default(DateTime))
                {
                    return minDate;
                }
                else
                {
                    return claim1Date;
                }
            }
            set { claim1Date = value; }
        }
            public DateTime Claim2Date
        {
            get
            {
                if (claim2Date == default(DateTime))
                {
                    return minDate;
                }
                else
                {
                    return claim2Date;
                }
            }
            set { claim2Date = value; }
        }
            public DateTime Claim3Date
        {
            get
            {
                if (claim3Date == default(DateTime))
                {
                    return minDate;
                }
                else
                {
                    return claim3Date;
                }
            }
            set { claim3Date = value; }
        }
            public DateTime Claim4Date
        {
            get
            {
                if (claim4Date == default(DateTime))
                {
                    return minDate;
                }
                else
                {
                    return claim4Date;
                }
            }
            set { claim4Date = value; }
        }
            public DateTime Claim5Date
        {
            get
            {
                if (claim5Date == default(DateTime))
                {
                    return minDate;
                }
                else
                {
                    return claim5Date;
                }
            }
            set { claim5Date = value; }
        }
    }
}
