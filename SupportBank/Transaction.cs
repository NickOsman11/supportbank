using System;

namespace SupportBank

{
    public class Transaction
    {
        public DateTime Timestamp { get; }
        public string Lender { get; }
        public string Borrower { get; }
        public string Description { get; }
        public decimal Amount { get; }
    }
}