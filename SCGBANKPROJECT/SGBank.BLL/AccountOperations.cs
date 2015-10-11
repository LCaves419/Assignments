using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGBank.Data;
using SGBank.Models;

namespace SGBank.BLL
{
    public class AccountOperations
    {
        public Response GetAccount(int AccountNumber)
        {
            var repo = new AccountRepository();
            var response = new Response();

            var account = repo.GetAccount(AccountNumber);

            if (account == null)
            {
                response.Success = false;
                response.Message = "This is not the Account you are looking for...";
            }
            else
            {
                response.Success = true;
                response.AccountInfo = account;
            }

            return response;
        }

        public Response Deposit(Account account, decimal Amount)
        {
            var response = new Response();

            if (Amount > 0)
            {
                account.Balance += Amount;
                var repo = new AccountRepository();
                repo.UpdateAccount(account);

                response.Success = true;
                response.DepositInfo = new DepositSlip();
                response.DepositInfo.AccountNumber = account.AccountNumber;
                response.DepositInfo.DepositAmount = Amount;
                response.DepositInfo.NewBalance = account.Balance;
            }
            else
            {
                response.Success = false;
                response.Message = "WTF You have to give a positive amount to deposit!";
            }

            return response;
        }

        public Response Withdraw(Account account, decimal Amount)
        {
            var response = new Response();

            if (Amount > account.Balance)
            {
                response.Success = false;
                response.Message = " Insufficent funds";
            }
            else
            {
                account.Balance -= Amount;
                var repo = new AccountRepository();
                repo.UpdateAccount(account);

                response.Success = true;
                response.WithdrawInfo = new WithdrawSlip();
                response.WithdrawInfo.AccountNumber = account.AccountNumber;
                response.WithdrawInfo.WithdrawalAmount = Amount;
                response.WithdrawInfo.NewBalance = account.Balance;

            }
            return response;
        }

        public Response CreateAccount()
        {
            AccountRepository repo = new AccountRepository();
            Account newAccount = new Account();
            Response response = new Response();

            newAccount.AccountNumber = 1;
            Console.Write("Account holder First name :");
            newAccount.FirstName = Console.ReadLine();
            Console.Write("Account holder Last name :");
            newAccount.LastName = Console.ReadLine();
          
            newAccount.Balance = 0.00M;
            

             int returnedAccountNumber = repo.WriteNewLine(newAccount);

            if (returnedAccountNumber == repo.GetAllAccounts().Count)
            {
                response.Success = true;

                response.CreateAccountInfo = new CreateAccountSlip();
                response.CreateAccountInfo.AccountNumber = returnedAccountNumber;
                response.CreateAccountInfo.FirstName = newAccount.FirstName;
                response.CreateAccountInfo.LastName = newAccount.LastName;
                response.CreateAccountInfo.NewBalance = newAccount.Balance;

            }
            else
            {
                response.Success = false;
                response.Message = "The account was not created, please try again.";
            }

            return response;
        }

        public Response Transfer()
        {
            Response response = new Response();
            return response;

        }


    }
}
