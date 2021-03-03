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
        
        public void Deposit(double amount)
		{
			if (amount > 0)
			{
				Console.WriteLine("\nPrevious Balance: " + balance);
				Console.WriteLine(+amount + "taka is the Deposited amount\n");

				balance = balance + amount;

				Console.WriteLine("Current Balance is: " + balance);
			}
			else
			{
				Console.WriteLine("\nCan Not Deposit...");
			}
		}
		public void Withdraw(double amount)
		{
			if (amount < 0)
			{
				Console.WriteLine("\n you can not withdraw the amount.");
			}
			else if (amount > balance)
			{
				Console.WriteLine(" \nthis withdrawal would pass the balance");
			}
			else
			{
				this.balance = (this.balance - amount);
				Console.WriteLine( + amount + "taka is the withdrawn amount ");
				Console.WriteLine("\nCurrent Balance: " + balance);
			}
		}
	    
	    public void Transfer(double amount, Account receiver)
		{
			if (amount < 0)
			{
				Console.WriteLine("\n you can not transfer the amount.");
			}
			else if (balance >= amount)
			{
				Withdraw(amount);
				receiver.Deposit(amount);
				Console.WriteLine("\n" + this.accountName + " has transfered " + amount + " taka to " + receiver.accountName + " account");
			}
			else
			{
				Console.WriteLine("\nInsufficient Balance");
			}
			Console.WriteLine("\n" + this.accountName + "'s current balance is " + balance);
			
		}




        public void ShowAccountInformation()
        {
            Console.WriteLine("Account No: "+this.accountNumber+"\nAccount Name: "+this.accountName+"\nAccount Balance: "+this.balance);
            
            this.address.GetAddress();


        }


    }
}

