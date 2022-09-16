using System;
using CsvHelper;
using System.IO;
using System.Globalization;
using System.Linq;

namespace SupportBank
{
    public static class FileReader
    {
        static public Ledger CreateLedger(string filePath) 
        {
            CultureInfo ukCulture = new CultureInfo("en-GB");
            List<Transaction> transactions;
            using (var streamReader = new StreamReader(filePath))
            {
                using (var csvReader = new CsvReader(streamReader, ukCulture))
                {
                    transactions = csvReader.GetRecords<Transaction>().ToList();
                }
            }
            return new Ledger(transactions);
        }
    }
}
