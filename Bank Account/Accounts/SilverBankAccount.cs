using System;

namespace NET.S._2018.Haiduk._08
{
    /// <summary>
    /// Class SilverBankAccount inherited from BankAccount
    /// </summary>
    public class SilverBankAccount : BankAccount
    {
        public SilverBankAccount(Client client, decimal startAmount) : base(client, startAmount)
        {
        }

        public override bool IsValidBalance(BankAccount account, decimal amount)
        {
            if ((Amount -= amount) < 500M)
            {
                return false;
                throw new InvalidOperationException("The amount on this account cannot be less than 500");
            }

            return true;
        }
    }
}