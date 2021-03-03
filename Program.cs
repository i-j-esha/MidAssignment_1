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

            Account[] a = new Account[3];

            a[0] = new Account(36160, "Bushra", 20000, new Address("05", "41", "Dhaka", "Bangladesh\n"));
            bank.AddAccount(a[0]);

            a[0].Deposit(2000);
            a[0].Withdraw(1500);

            a[1] = new Account(18101, "Alif", 10000, new Address("21", "52", "Dhaka", "Bangladdesh\n"));
            bank.AddAccount(a[1]);

            a[1].Deposit(5000);
            a[1].Withdraw(3000);
            a[0].Transfer(1000, a[1]);

            bank.PrintAccountDetails();


        }
    }
}
