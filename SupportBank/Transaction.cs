using System;
using System.Globalization;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace SupportBank

{
    public class Transaction
    {
        [Name("Date")]
        public DateTime Timestamp { get; set; }
        [Name("From")]  
        public string Lender { get; set; }
        [Name("To")]
        public string Borrower { get; set; }
        [Name("Narrative")]
        public string Description { get; set; }
        [Name("Amount")]
        public decimal Amount { get; set; }
    }
}