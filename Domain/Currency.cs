using System;
using System.Collections.Generic;

namespace Domain
{
    public class Currency
    {
        public Guid CurrencyId { get; set; }
        public string Abreviation { get; set; }
        public List<Expense> Expenses { get; set; }

        public Currency(string abreviation)
        {
            Abreviation = abreviation;
            Expenses = new ();
        }
    }
}