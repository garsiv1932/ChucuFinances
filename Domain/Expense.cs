using System;

namespace Domain
{
    public class Expense
    {
        public Guid ExpenseId { get; set; }
        public User User { get; set; }
        public double Amount { get; set; }
        public string Detail { get; set; }
        public ExpenseType Type { get; set; }
        


    }
}