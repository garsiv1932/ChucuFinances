using System;
using System.Collections.Generic;

namespace Domain
{
    public class ExpenseType
    {
        public Guid ExpenseTypeId { get; set; }
        public string Name { get; set; }
        public List<Expense> Expenses { get; set; }

        public ExpenseType(string name )
        {
            Name = name;
            Expenses = new ();
        }
    }
}