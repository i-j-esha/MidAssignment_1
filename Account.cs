using System;


namespace MidAssignment_1
{
    class Account
    {
        private int accountNumber;
        private string accountName;
        private double balance;
        private Address address;

        public Account(int accountNumber, string accountName, double balance, Address address )
        {
            this.accountNumber = accountNumber;
            this.accountName = accountName;
            this.balance = balance;
            this.address = address;
        }

        //property
        public int AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }

        public string AccountName
        {
            get { return this.accountName; }
            set { this.accountName = value; }
        }

        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public void ShowAccountInformation()
        {
            Console.WriteLine("Account No: "+this.accountNumber+"\nAccount Name: "+this.accountName+"\nAccount Balance: "+this.balance);
            
            this.address.GetAddress();


        }


    }
}

