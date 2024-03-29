﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsibility
{
    public class ATM
    {
        private IDispenseChain _chain1;
        private IDispenseChain _chain2;
        private IDispenseChain _chain3;
        private IDispenseChain _chain4;
        private IDispenseChain _chain5;


        public ATM()
        {
            _chain1 = new DollarDispenser(1000);
            _chain2 = new DollarDispenser(500);
            _chain3 = new DollarDispenser(200);
            _chain4 = new DollarDispenser(100);
            _chain5 = new DollarDispenser(50);


            // Set chain of respensibility
            _chain1.setNext(_chain2);
            _chain2.setNext(_chain3);
            _chain3.setNext(_chain4);
            _chain4.setNext(_chain5);

        }

        public void Dispense(Currency currency)
        {
            _chain1.Dispense(currency);
        }
    }
}
