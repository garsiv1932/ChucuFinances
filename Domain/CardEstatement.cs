using System;
using System.Collections.Generic;

namespace Domain
{
    public class CardEstatement
    {
        public Guid CardEstatementId { get; set; }
        public User User { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime PaymentDate { get; set; }
        public List<Expense> ExpenseRows { get; set; }
        public CurrencyExchangeRate CurrencyExchangeRate { get; set; }
        public Card Card { get; set; }

        public CardEstatement(User user, DateTime expirationDate, DateTime paymentDate, List<Expense> expenseRows, CurrencyExchangeRate currencyExchangeRate)
        {
            User = user;
            ExpirationDate = expirationDate;
            PaymentDate = paymentDate;
            ExpenseRows = expenseRows;
            CurrencyExchangeRate = currencyExchangeRate;
        }
    }
}