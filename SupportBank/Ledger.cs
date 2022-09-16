namespace SupportBank
{
    public class Ledger
    {
        public List<Transaction> TransactionsToDate { get; }
        public List<Account> Accounts { get; }

        public Ledger(List<Transaction> list)
        {
            TransactionsToDate = list;
            Accounts = GetAccounts();
        }

        private List<Account> GetAccounts()
        {
            HashSet<string> nameList = new HashSet<string>();
            foreach (Transaction transaction in TransactionsToDate)
            {
                nameList.Add(transaction.Lender);
                nameList.Add(transaction.Borrower);
            }
            List<Account> accounts = new List<Account>();
            foreach (string name in nameList)
            {
                accounts.Add(new Account(name));
            }
            return accounts;
        }

        public decimal GetBalance(Account account)
        {
            decimal borrowed = 0M;
            decimal lent = 0M;
            foreach (Transaction transaction in TransactionsToDate)
            {
                if (transaction.Lender == account.Name)
                {
                    lent += transaction.Amount;
                }
                else if (transaction.Borrower == account.Name)
                {
                    borrowed += transaction.Amount;
                }
            }
            return lent - borrowed;
        }
    }
}
