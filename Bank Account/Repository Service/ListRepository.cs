using System;
using System.Collections.Generic;
using System.Linq;

namespace NET.S._2018.Haiduk._08.RepositoryService
{
    public class ListRepository : IRepository
    {
        private List<BankAccount> bankAccounts = new List<BankAccount>();

        /// <summary>
        /// Method for adding new account into Account repository
        /// </summary>
        /// <param name="client">Owner of account</param>
        /// <param name="startAmount">Value of start amount</param>
        public void Create(Client client, decimal startAmount)
        {
            if (startAmount >= 0m && startAmount < 1000m)
            {
                var account = new BaseBankAccount(client, startAmount);
                bankAccounts.Add(account);
            }
            else if (startAmount >= 1000m && startAmount < 5000m)
            {
                var account = new SilverBankAccount(client, startAmount);
                bankAccounts.Add(account);
            }
            else if (startAmount >= 5000m && startAmount < 10000m)
            {
                var account = new GoldBankAccount(client, startAmount);
                bankAccounts.Add(account);
            }
            else if (startAmount >= 10000m)
            {
                var account = new PlatinumBankAccount(client, startAmount);
                bankAccounts.Add(account);
            }
        }

        /// <summary>
        /// Method for deleting existing account from Account repository
        /// </summary>
        /// <param name="accountNumber">Number of account to delete</param>
        public void Delete(int accountNumber) => bankAccounts.Remove(bankAccounts.Where(b => b.AccountNumber == accountNumber).FirstOrDefault());

        /// <summary>
        /// Method for retrieving account from Account repository
        /// </summary>
        /// <param name="client">Information about account owner</param>
        /// <returns>Account of accepted owner</returns>
        public BankAccount Read(Client client) => bankAccounts.Where(b => b.Client == client).FirstOrDefault();

        /// <summary>
        /// Method for updating information about existing account in repository
        /// </summary>
        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
