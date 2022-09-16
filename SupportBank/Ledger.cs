namespace SupportBank
{
    public class Ledger
    {
        public List<Transaction> TransactionsToDate { get; }

        public Ledger(List<Transaction> list)
        {
            TransactionsToDate = list;
        }

    }
}