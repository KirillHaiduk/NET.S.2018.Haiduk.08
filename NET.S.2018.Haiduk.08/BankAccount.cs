namespace NET.S._2018.Haiduk._08
{
    /// <summary>
    /// Class that describes Bank Account and contains methods for working with it
    /// </summary>
    public abstract class BankAccount
    {
        public Client Owner;

        public bool Closed;

        /// <summary>
        /// The ID number of Bank Account
        /// </summary>
        public int AccountNumber { get; set; }

        /// <summary>
        /// Firstname of the owner of Bank Account
        /// </summary>
        public string OwnerInfo => Owner.Firstname + Owner.Lastname;
                
        /// <summary>
        /// Amount of Bank Account
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Bonus Points that add or substarct while working with amount
        /// </summary>
        public double BonusPoints { get; set; }
                
        /// <summary>
        /// Virtual method for refilling Bank Account
        /// </summary>        
        /// <param name="amount">Amount value</param>        
        /// <returns>Amount after refilling</returns>
        public decimal Deposit(decimal amount)
        {
            BonusPoints += CalculateBonusPoints(amount);
            return Amount += amount;
        }

        /// <summary>
        /// Virtual method for write-off Bank Account
        /// </summary>        
        /// <param name="amount">Amount value</param>        
        /// <returns>Amount after write-off</returns>
        public decimal Withdraw(decimal amount)
        {
            if (IsValidBalance(this, amount))
            {
                BonusPoints -= CalculateBonusPoints(amount);
                Amount -= amount;
            }

            return Amount;
        }

        /// <summary>
        /// Method for creaing Bank Account
        /// </summary>
        /// <param name="account">Account that is creating</param>
        public void CreateAccount(BankAccount account)
        {
            return;
        }

        /// <summary>
        /// Method for clothing Bank Account
        /// </summary>
        /// <param name="account">Account that is closing</param>
        public void CloseAccount(BankAccount account)
        {
            return;
        }

        public abstract double CalculateBonusPoints(decimal amount);

        public abstract bool IsValidBalance(BankAccount account, decimal amount);
    }    
}