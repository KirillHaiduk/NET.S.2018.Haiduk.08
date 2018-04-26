using System;

namespace NET.S._2018.Haiduk._08
{
    /// <summary>
    /// Class BaseBankAccount inherited from BankAccount
    /// </summary>
    public class BaseBankAccount : BankAccount
    {
        public BaseBankAccount(Client client, decimal startAmount) : base(client, startAmount)
        {
        }

        public override bool IsValidBalance(BankAccount account, decimal amount)
        {
            if ((Amount -= amount) < 0)
            {
                return false;
                throw new InvalidOperationException("The amount on this account cannot be less than 0");                
            }

            return true;
        }
    }
}