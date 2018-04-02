using System;

namespace NET.S._2018.Haiduk._08
{
    /// <summary>
    /// Class PlatinumBankAccount inherited from BankAccount
    /// </summary>
    public class PlatinumBankAccount : BankAccount
    {
        /// <summary>
        /// Constant number for calculating Bonus Points
        /// </summary>
        private const decimal Bonus = 0.1M;        

        public override double CalculateBonusPoints(decimal amount)
        {
            return BonusPoints = (double)((Amount * Bonus) + (amount * Bonus));
        }

        public override bool IsValidBalance(BankAccount account, decimal amount)
        {
            if ((Amount -= amount) < 2000M)
            {
                return false;
                throw new InvalidOperationException("The amount on this account cannot be less than 2000");
            }

            return true;
        }
    }
}