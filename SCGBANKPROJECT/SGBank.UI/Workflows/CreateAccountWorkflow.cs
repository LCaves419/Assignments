using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using SGBank.BLL;
using SGBank.Models;

namespace SGBank.UI.Workflows
{
    public class CreateAccountWorkflow
    {
        private Account _currentAccount;

        public void Execute()
        {
            OpenAccount();
        }

        public void OpenAccount()
        {
            AccountOperations ops = new AccountOperations();
            Response response = ops.CreateAccount();

            if (response.Success)
            {
                Console.WriteLine();
                Console.WriteLine("New Account Created");
                Console.WriteLine("First Name: {0} ", response.CreateAccountInfo.FirstName);
                Console.WriteLine("Last Name: {0}", response.CreateAccountInfo.LastName);
                Console.WriteLine("Account number: {0}", response.CreateAccountInfo.AccountNumber);
                Console.WriteLine("Balance: {0}", response.CreateAccountInfo.NewBalance);
                Console.WriteLine("Press enter to continue.....");
                Console.ReadLine();
            }

        }



    }
}
