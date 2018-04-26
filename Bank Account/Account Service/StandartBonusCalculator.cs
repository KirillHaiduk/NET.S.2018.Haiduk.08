using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2018.Haiduk._08.Account_Service
{
    public class StandartBonusCalculator : IBonusCalculator
    {
        public double CalculateBonusPoints(decimal amount, BankAccount account)
        {
            switch (account.GetType().Name)
            {
                case "BaseBankAccount":
                    return (double)((account.Amount + amount) * 0.0001m);
                case "SilverBankAccount":
                    return (double)((account.Amount + amount) * 0.001m);
                case "GoldBankAccount":
                    return (double)((account.Amount + amount) * 0.01m);
                case "PlatinumBankAccount":
                    return (double)((account.Amount + amount) * 0.1m);
                default:
                    return 0;
            }
        }
    }
}
