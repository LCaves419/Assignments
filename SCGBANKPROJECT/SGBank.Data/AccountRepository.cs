using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGBank.Models;

namespace SGBank.Data
{
    public class AccountRepository
    {
        private const string _filePath = @"DataFiles\Bank.txt";

        public List<Account> GetAllAccounts()
        {
            List<Account> accounts = new List<Account>();

            //read all lines in file\Bank.txt
            var reader = File.ReadAllLines(_filePath);

            //i = 1 starts on line 1 not 0.
            for (int i = 1; i < reader.Length; i++)
            {
                var columns = reader[i].Split(',');

                var account = new Account();

                account.AccountNumber = int.Parse(columns[0]);
                account.FirstName = columns[1];
                account.LastName = columns[2];
                account.Balance = decimal.Parse(columns[3]);

                accounts.Add(account);
            }

            return accounts;
        }

        public Account GetAccount(int AccountNumber)
        {
            List<Account> accounts = GetAllAccounts();
            return accounts.FirstOrDefault(a => a.AccountNumber == AccountNumber);
        }

        public void UpdateAccount(Account accountToUpdate)
        {
            var accounts = GetAllAccounts();

            var account = accounts.First(a => a.AccountNumber == accountToUpdate.AccountNumber);
            account.Balance = accountToUpdate.Balance;

            OverwriteFile(accounts);
        }

        public void OverwriteFile(List<Account> accounts)
        {
            File.Delete(_filePath);

            using (var writer = File.CreateText(_filePath))
            {
                writer.WriteLine("AccountNumber,FirstName,LastName,Balance");

                foreach (var account in accounts)
                {
                    writer.WriteLine("{0},{1},{2},{3}", account.AccountNumber, account.FirstName,
                        account.LastName, account.Balance);
                }
            }
        }

        //Create Account
        public int WriteNewLine(Account account)
        {
            //write a new line a way to calculate new line number
            var accounts = GetAllAccounts();
            int newAccountNumber = accounts.Count+1;//+1 will be the new acct number

            using (var writer = File.AppendText(_filePath))//appends to the end of existing file
            {
                writer.WriteLine("{0},{1},{2},{3}", newAccountNumber, account.FirstName,
                        account.LastName, account.Balance);
            }

            return newAccountNumber;
        }


    }//end class
}
