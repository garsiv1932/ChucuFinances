using System;

namespace Domain
{
    public class CurrencyExchangeRate
    {
        public DateTime Date { get; set; }
        public double SellRate { get; set; }
        public double BuyRate { get; set; }
    }
}