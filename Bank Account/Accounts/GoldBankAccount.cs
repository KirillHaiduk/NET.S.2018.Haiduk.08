using System;

namespace NET.S._2018.Haiduk._08
{
    /// <summary>
    /// Class GoldBankAccount inherited from BankAccount
    /// </summary>
    public class GoldBankAccount : BankAccount
    {
        public GoldBankAccount(Client client, decimal startAmount) : base(client, startAmount)
        {
        }

        public override bool IsValidBalance(BankAccount account, decimal amount)
        {
            if ((Amount -= amount) < 1000M)
            {
                return false;
                throw new InvalidOperationException("The amount on this account cannot be less than 1000");
            }

            return true;
        }
    }
}