using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidAssignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Address address0 = new Address("05", "41", "Dhaka", "Bangladesh");
            //Account account0 = new Account(36160, "Bushra", 20000, address0);

          

            //Account account0 = new Account(36160, "Bushra", 20000, new Address("05", "41", "Dhaka", "Bangladesh"));
            //account0.ShowAccountInformation();

            Bank bank = new Bank("Developer Bank", 5);
            bank.AddAccount(new Account(36160, "Bushra", 20000, new Address("05", "41", "Dhaka", "Bangladesh\n")));
            bank.AddAccount(new Account(18101, "Alif", 10000, new Address("21", "52", "Dhaka", "Bangladdesh\n")));

           Account[] account = new Account[5];

            account[0] = new Account(36160, "Bushra", 20000, new Address("05", "41", "Dhaka", "Bangladesh\n"));
            bank.AddAccount(account[0]);

            account[0].Deposit(2000);
            account[0].Withdraw(1500);

            account[1] = new Account(18101, "Alif", 10000, new Address("21", "52", "Dhaka", "Bangladdesh\n"));
            bank.AddAccount(account[1]);

            account[1].Deposit(5000);
            account[1].Withdraw(3000);
            account[0].Transfer(1000, account[1]);


            bank.PrintAccountDetails();

          
        }
    }
}
