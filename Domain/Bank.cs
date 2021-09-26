using System;
using System.Collections.Generic;

namespace Domain
{
    public class Bank
    {
        public Guid BankId { get; set; }
        public string Name { get; set; }
        public List<Card> Cards { get; set; }
        public List<BankAccount> BankAccounts { get; set; }

        public Bank(string name)
        {
            Name = name;
            Cards = new();
            BankAccounts = new();
        }
    }
}