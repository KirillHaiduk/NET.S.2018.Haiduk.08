using System;

namespace NET.S._2018.Haiduk._08
{
    /// <summary>
    /// Class PlatinumBankAccount inherited from BankAccount
    /// </summary>
    public class PlatinumBankAccount : BankAccount
    {
        public PlatinumBankAccount(Client client, decimal startAmount) : base(client, startAmount)
        {
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