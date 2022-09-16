namespace SupportBank
{
    class Program
    {
        public static void Main(string[] args)
        {
            Ledger ledger = FileReader.CreateLedger("./Transactions2014.txt");
            Account laura = new Account ("Laura B");
            Console.WriteLine(ledger.GetBalance(laura));
        }
    }
}
