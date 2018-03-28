namespace NET.S._2018.Haiduk._08
{
    /// <summary>
    /// Class PlatinumBankAccount inherited from BankAccount
    /// </summary>
    public class PlatinumBankAccount : BankAccount
    {
        /// <summary>
        /// Type of Bank Account is Platinum
        /// </summary>
        public new BalanceType Type { get => BalanceType.Platinum; }

        /// <summary>
        /// Overriding of base class method Refill according to BalanceType
        /// </summary>        
        /// <param name="amount">Amount value</param>        
        /// <returns>Amount after refilling</returns>
        public override decimal Refill(decimal amount)
        {
            BonusPoints += 40;
            return Amount += amount;
        }

        /// <summary>
        /// Overriding of base class method Debit according to BalanceType
        /// </summary>        
        /// <param name="amount">Amount value</param>        
        /// <returns>Amount after write-off</returns>
        public override decimal Debit(decimal amount)
        {
            BonusPoints -= 40;
            return Amount -= amount;
        }
    }
}