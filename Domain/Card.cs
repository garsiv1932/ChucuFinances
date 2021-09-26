using System;
using System.Collections.Generic;

namespace Domain
{
    public class Card
    {
        public Guid CardId { get; set; }
        public string CardName { get; set; }
        public List<CardEstatement> CardEstatements { get; set; }
        public Bank Bank { get; set; }
        public DateTime ClosingDate { get; set; }
        
    }
}