namespace SupportBank
{
    public class Ledger
    {
        public List<Transaction> TransactionsToDate { get; }

        public Ledger(List<Transaction> list)
        {
            TransactionsToDate = list;
        }

        public List<Account> GetAccounts()
        {
            List<string> nameList = new List<string>();
            foreach (Transaction transaction in TransactionsToDate)
            {
                if (!nameList.Contains(transaction.Lender))
                {
                    nameList.Add(transaction.Lender);
                }
                if (!nameList.Contains(transaction.Borrower))
                {
                    nameList.Add(transaction.Borrower);
                }
            }
            List<Account> accounts = new List<Account>();
            foreach (string name in nameList)
            {
                accounts.Add(new Account(name));
            }
            return accounts;
        }
    }
}
