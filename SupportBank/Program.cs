namespace SupportBank
{
    class Program
    {
        public static void Main(string[] args)
        {
            Ledger ledger = FileReader.CreateLedger("./Transactions2014.txt");
        }
    }
}
