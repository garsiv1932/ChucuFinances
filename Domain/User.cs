using System;
using System.Collections.Generic;

namespace Domain
{
    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime BornDate { get; set; }
        public List<CardEstatement> CardEstatements { get; set; }
        public List<Expense> Expenses { get; set; }
        public List<BankAccount> BankAccounts { get; set; }

        public User(string email, string password, DateTime bornDate)
        {
            Email = email;
            Password = password;
            BornDate = bornDate;
            CardEstatements = new ();
            Expenses = new ();
            BankAccounts = new ();
        }
    }
}