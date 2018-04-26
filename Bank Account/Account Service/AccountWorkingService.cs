using NET.S._2018.Haiduk._08.Account_Service;

namespace NET.S._2018.Haiduk._08
{
    /// <summary>
    /// Class for working with Bank account
    /// </summary>
    public class AccountWorkingService
    {
        /// <summary>
        /// Method for creaing Bank Account
        /// </summary>
        /// <param name="account">Account that is creating</param>
        public void CreateAccount(IRepository repository, Client client, decimal startAmount)
        {
            repository.Create(client, startAmount);
        }

        /// <summary>
        /// Method for clothing Bank Account
        /// </summary>
        /// <param name="account">Account that is closing</param>
        public void CloseAccount(IRepository repository, BankAccount account)
        {
            repository.Delete(account.AccountNumber);
        }

        /// <summary>
        /// Virtual method for refilling Bank Account
        /// </summary>        
        /// <param name="amount">Amount value</param>        
        /// <returns>Amount after refilling</returns>
        public decimal Deposit(BankAccount account, decimal amount, IBonusCalculator bonusCalculator)
        {
            account.BonusPoints += bonusCalculator.CalculateBonusPoints(amount, account);
            return account.Amount += amount;
        }

        /// <summary>
        /// Virtual method for write-off Bank Account
        /// </summary>        
        /// <param name="amount">Amount value</param>        
        /// <returns>Amount after write-off</returns>
        public decimal Withdraw(BankAccount account, decimal amount, IBonusCalculator bonusCalculator)
        {
            if (account.IsValidBalance(account, amount))
            {
                account.BonusPoints -= bonusCalculator.CalculateBonusPoints(amount, account);
                account.Amount -= amount;
            }

            return account.Amount;
        }
    }
}
