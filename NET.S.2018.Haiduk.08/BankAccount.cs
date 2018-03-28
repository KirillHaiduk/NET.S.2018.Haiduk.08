namespace NET.S._2018.Haiduk._08
{
    /// <summary>
    /// Class that describes Bank Account and contains methods for working with it
    /// </summary>
    public abstract class BankAccount
    {
        /// <summary>
        /// Enum that contains types of Bank Account
        /// </summary>
        public enum BalanceType
        {
            Base = 1, Silver, Gold, Platinum
        }

        /// <summary>
        /// The ID number of Bank Account
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Firstname of the owner of Bank Account
        /// </summary>
        public string OwnerFirstname { get; set; }

        /// <summary>
        /// Lastname of the owner of Bank Account
        /// </summary>
        public string OwnerLastname { get; set; }

        /// <summary>
        /// Amount of Bank Account
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Bonus Points that add or substarct while working with amount
        /// </summary>
        public int BonusPoints { get; set; }

        /// <summary>
        /// Type of Bank Account
        /// </summary>
        public BalanceType Type { get; set; }

        /// <summary>
        /// Virtual method for refilling Bank Account
        /// </summary>        
        /// <param name="amount">Amount value</param>        
        /// <returns>Amount after refilling</returns>
        public virtual decimal Refill(decimal amount)
        {
            return Amount += amount;
        }

        /// <summary>
        /// Virtual method for write-off Bank Account
        /// </summary>        
        /// <param name="amount">Amount value</param>        
        /// <returns>Amount after write-off</returns>
        public virtual decimal Debit(decimal amount)
        {
            return Amount -= amount;
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
    }    
}