﻿using System;
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

            Bank ourBank = new Bank("Developer Bank", 5);
            ourBank.AddAccount(new Account(36160, "Bushra", 20000, new Address("05", "41", "Dhaka", "Bangladesh")));
            ourBank.AddAccount(new Account(18101, "Alif", 3000, new Address("21", "52", "Dhaka", "Bangladdesh")));
            
            
            
            ourBank.PrintAccountDetails();


        }
    }
}