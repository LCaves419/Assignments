using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGBank.BLL;
using SGBank.Models;

namespace SGBank.UI.Workflows
{
    public class WithdrawWorkflow
    {
        private Account _currentAccount;

        public void Execute(Account account)
        {
            _currentAccount = account;
            decimal amount = GetWithdrawFromUser();
            MakeWithdrawl(amount);
        }

        public decimal GetWithdrawFromUser()
        {
            do
            {
                Console.WriteLine("Enter withdral amount:");
                string input = Console.ReadLine();

                decimal withdrawAmount;
                if (decimal.TryParse(input, out withdrawAmount))
                {
                    return withdrawAmount;
                }

                Console.WriteLine("This was not a valid amount...");
                Console.WriteLine("Press enter to continue....");
                Console.ReadLine();
            } while (true);
        }

        public void MakeWithdrawl(decimal Amount)
        {
            var ops = new AccountOperations();
            var response = ops.Withdraw(_currentAccount, Amount);

            if (response.Success)
            {
                Console.WriteLine();
                Console.WriteLine("Withdrawn {0:c} from account {1}.", response.WithdrawInfo.WithdrawalAmount,
                    response.WithdrawInfo.AccountNumber);
                Console.WriteLine("New Balance: {0:c}", response.WithdrawInfo.NewBalance);
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
        }

    }
}
