namespace NET.S._2018.Haiduk._08
{
    /// <summary>
    /// Class BaseBankAccount inherited from BankAccount
    /// </summary>
    public class BaseBankAccount : BankAccount
    {
        /// <summary>
        /// Type of Bank Account is Base
        /// </summary>
        public new BalanceType Type { get => BalanceType.Base; }

        /// <summary>
        /// Overriding of base class method Refill according to BalanceType
        /// </summary>        
        /// <param name="amount">Amount value</param>        
        /// <returns>Amount after refilling</returns>
        public override decimal Refill(decimal amount)
        {
            BonusPoints += 10;
            return Amount += amount;
        }

        /// <summary>
        /// Overriding of base class method Debit according to BalanceType
        /// </summary>        
        /// <param name="amount">Amount value</param>        
        /// <returns>Amount after write-off</returns>
        public override decimal Debit(decimal amount)
        {
            BonusPoints -= 10;
            return Amount -= amount;
        }
    }
}